using WebServer.Application;
using WebServer.Server;
using WebServer.Server.Contracts;
using WebServer.Server.Routing;

namespace WebServer
{
    public class Launcher : IRunnable
    {
        private MyWebServer webServer;

        public static void Main()
        {
            new Launcher().Run();
        }

        public void Run()
        {
            var app = new MainApplication();
            var routeConfig = new AppRouteConfig();
            app.Start(routeConfig);

            this.webServer = new MyWebServer(8230, routeConfig);
            this.webServer.Run();
        }
    }
}
