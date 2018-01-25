using FluffyDuffyMunchkinCats.Data;
using FluffyDuffyMunchkinCats.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace FluffyDuffyMunchkinCats
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CatsDbContext>(options => options.UseSqlServer("Server=.;Database=Cats;Integrated Security=True"));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Use((context, next) =>
            {
                context.RequestServices.GetRequiredService<CatsDbContext>().Database.Migrate();

                return next();
            });

            app.UseStaticFiles();

            app.Use((context, next) =>
            {
                context.Response.Headers.Add("Content-Type", "text/html");

                return next();
            });

            app.MapWhen(ctx => ctx.Request.Path.Value.Equals("/") && ctx.Request.Method.Equals(HttpMethod.Get), home =>
            {
                home.Run(async (context) =>
                {
                    await context.Response.WriteAsync($"<h1>{env.ApplicationName}</h1>");

                    var db = context.RequestServices.GetRequiredService<CatsDbContext>();

                    var catData = db.Cats.Select(cat => new
                    {
                        cat.Id,
                        cat.Name
                    }).ToList();

                    await context.Response.WriteAsync("<ul>");

                    foreach (var cat in catData)
                    {
                        await context.Response.WriteAsync($@"<li><a href=""/cat/{cat.Id}"">{cat.Name}</a></li>");
                    }

                    await context.Response.WriteAsync("</ul>");
                    await context.Response.WriteAsync(@"<form action=""/cat/add""><input type=""submit"" value=""Add Cat"" /></form>");
                });
            });

            app.MapWhen(ctx => ctx.Request.Path.Value.Equals("/cat/add"), catAdd =>
            {
                catAdd.Run(async (context) =>
                {
                    if (context.Request.Method.Equals(HttpMethod.Get))
                    {
                        context.Response.Redirect("/cats-add-form.html");
                    }
                    else if (context.Request.Method.Equals(HttpMethod.Post))
                    {
                        var db = context.RequestServices.GetRequiredService<CatsDbContext>();

                        var formData = context.Request.Form;

                        var cat = new Cat
                        {
                            Name = formData["Name"],
                            Age = int.Parse(formData["Age"]),
                            Breed = formData["Breed"],
                            ImageUrl = formData["ImageUrl"],
                        };

                        db.Add(cat);

                        try
                        {
                            await db.SaveChangesAsync();

                            context.Response.Redirect("/");
                        }
                        catch
                        {
                            await context.Response.WriteAsync("<h2>Invalid cat data</h2>");
                            await context.Response.WriteAsync(@"<a href=""/cat/add"">Back To The Form</a>");
                        }
                    }
                });
            });

            app.MapWhen(ctx => ctx.Request.Path.Value.StartsWith("/cat") && ctx.Request.Method.Equals(HttpMethod.Get), catData =>
            {
                catData.Run(async (context) =>
                {
                    var urlParts = context.Request.Path.Value.Split('/', System.StringSplitOptions.RemoveEmptyEntries);

                    if (urlParts.Length < 2)
                    {
                        context.Response.Redirect("/");
                        return;
                    }

                    int.TryParse(urlParts[1], out int catId);

                    if (catId == 2)
                    {
                        context.Response.Redirect("/");
                        return;
                    }

                    var db = context.RequestServices.GetRequiredService<CatsDbContext>();

                    var cat = await db.Cats.FindAsync(catId);

                    if (cat == null)
                    {
                        context.Response.Redirect("/");
                        return;
                    }

                    await context.Response.WriteAsync($"<h1>{cat.Name}</h1>");
                    await context.Response.WriteAsync($@"<img src=""{cat.ImageUrl}"" alt=""{cat.Name}"" width=""300"" />");
                    await context.Response.WriteAsync($"<p>Age: {cat.Age}</p>");
                    await context.Response.WriteAsync($"<p>Breed: {cat.Breed}</p>");
                });
            });

            app.Run(async (context) =>
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("Page not found");
            });
        }
    }
}
