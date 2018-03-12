using LearningSystem.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using LearningSystem.Data.Models;
using System.Threading.Tasks;
using System;

namespace LearningSystem.Web.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseDatabaseMigrations(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetService<LearningSystemDbContext>().Database.Migrate();

                var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                Task.Run(async () =>
                {
                    var roles = new string[]
                    {
                        "Administrator",
                        "Trainer",
                        "BlogAuthor"
                    };

                    foreach (var role in roles)
                    {
                        var roleExists = await roleManager.RoleExistsAsync(role);

                        if (!roleExists)
                        {
                            await roleManager.CreateAsync(new IdentityRole
                            {
                                Name = role
                            });
                        }
                    }

                    var adminUsername = "DefaultAdmin";

                    var adminUser = await userManager.FindByNameAsync(adminUsername);

                    var roleName = "Administrator";

                    if (adminUser == null)
                    {
                        adminUser = new User
                        {
                            UserName = adminUsername,
                            Name = "Admin",
                            Email = "admin@admin.com",
                            BirthDay = DateTime.Now.AddYears(-30)
                        };

                        await userManager.CreateAsync(adminUser, "asqasq");
                        await userManager.AddToRoleAsync(adminUser, roleName);
                    }
                }).Wait();
            }

            return app;
        }
    }
}
