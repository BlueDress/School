using SimpleMvc.Framework.Contracts;
using SimpleMvc.Framework.Controllers;

namespace ModPanell.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
