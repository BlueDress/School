using WebServer.Application.Controllers;
using WebServer.Server.Contracts;
using WebServer.Server.Handlres;
using WebServer.Server.Routing.Contracts;

namespace WebServer.Application
{
    public class MainApplication : IApplication
    {
        public void Start(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig.AddRoute("/", new GetHandler(httpContext => new HomeController().Index()));

            appRouteConfig.AddRoute("/register", new PostHandler(httpContext => new UserController().RegisterPost(httpContext.FormData["name"])));

            appRouteConfig.AddRoute("/register", new GetHandler(httpContext => new UserController().RegisterGet()));

            appRouteConfig.AddRoute("/user/{(?<name>[a-z]+)}", new GetHandler(httpContex => new UserController().Details(httpContex.UrlParameters["name"])));
        }
    }
}
