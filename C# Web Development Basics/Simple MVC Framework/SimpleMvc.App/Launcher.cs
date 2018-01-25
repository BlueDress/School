using SimpleMvc.Framework;
using SimpleMvc.Framework.Routers;

namespace SimpleMvc.App
{
    using WebServer;

    public class Launcher
    {
        public static void Main()
        {
            MvcEngine.Run(new WebServer(8000, new ControllerRouter()));
        }
    }
}
