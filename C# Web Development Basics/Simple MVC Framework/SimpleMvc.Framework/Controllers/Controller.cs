using SimpleMvc.Framework.Interfaces;
using SimpleMvc.Framework.Interfaces.Generic;
using SimpleMvc.Framework.ViewEngine;
using SimpleMvc.Framework.ViewEngine.Generic;
using System.Runtime.CompilerServices;

namespace SimpleMvc.Framework.Controllers
{
    public class Controller
    {
        protected IActionResult View([CallerMemberName] string caller = "")
        {
            var controllerName = this.GetType().Name.Replace(MvcContext.Get.ControllersSuffix, string.Empty);

            var fullQualifiedName = string.Format($"{MvcContext.Get.AssemblyName}.{MvcContext.Get.ViewsFolder}.{controllerName}.{caller}, {MvcContext.Get.AssemblyName}");

            return new ActionResult(fullQualifiedName);
        }

        protected IActionResult<T> View<T>(T model, [CallerMemberName] string caller = "")
        {
            var controllerName = this.GetType().Name.Replace(MvcContext.Get.ControllersSuffix, string.Empty);

            var fullQualifiedName = string.Format($"{MvcContext.Get.AssemblyName}.{MvcContext.Get.ViewsFolder}.{controllerName}.{caller}, {MvcContext.Get.AssemblyName}");

            return new ActionResult<T>(fullQualifiedName, model);
        }

        protected IActionResult View(string controller, string action)
        {
            var fullQualifiedName = string.Format($"{MvcContext.Get.AssemblyName}.{MvcContext.Get.ViewsFolder}.{controller}.{action}, {MvcContext.Get.AssemblyName}");

            return new ActionResult(fullQualifiedName);
        }

        protected IActionResult<T> View<T>(T model, string controller, string action)
        {
            var fullQualifiedName = string.Format($"{MvcContext.Get.AssemblyName}.{MvcContext.Get.ViewsFolder}.{controller}.{action}, {MvcContext.Get.AssemblyName}");

            return new ActionResult<T>(fullQualifiedName, model);
        }
    }
}
