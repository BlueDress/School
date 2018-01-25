using SimpleMvc.Framework;
using SimpleMvc.Framework.Routers;

namespace ModPanell.App
{
    public class Launcher
    {
        public static void Main()
        {
            MvcEngine.Run(new WebServer.WebServer(8055, new ControllerRouter(), new ResourceRouter()));
        }
    }
}
