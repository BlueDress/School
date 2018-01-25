using SimpleMvc.Framework.Attributes.Method;
using SimpleMvc.Framework.Controllers;
using SimpleMvc.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WebServer.Contracts;
using WebServer.Enums;
using WebServer.Exceptions;
using WebServer.Http.Contracts;
using WebServer.Http.Response;

namespace SimpleMvc.Framework.Routers
{
    public class ControllerRouter : IHandleable
    {
        private IDictionary<string, string> getParams;
        private IDictionary<string, string> postParams;
        private string requestMethod;
        private string controllerName;
        private string actionName;
        private object[] methodParams;

        public ControllerRouter()
        {

        }

        private void PrepareControllerAndActionNames(IHttpRequest request)
        {
            var pathParts = request.Path.Split(new char[] { '/', '?' }, StringSplitOptions.RemoveEmptyEntries);

            if (pathParts.Length > 2)
            {
                BadRequestException.ThrowFromInvalidRequest();
            }

            this.controllerName = $"{char.ToUpper(pathParts[0][0])}{pathParts[0].Substring(1)}{MvcContext.Get.ControllersSuffix}";

            this.actionName = $"{char.ToUpper(pathParts[1][0])}{pathParts[1].Substring(1)}";
        }

        public IHttpResponse Handle(IHttpRequest request)
        {
            this.getParams = new Dictionary<string, string>(request.UrlParameters);
            this.postParams = new Dictionary<string, string>(request.FormData);
            this.requestMethod = request.Method.ToString().ToUpper();

            this.PrepareControllerAndActionNames(request);

            var methodInfo = this.GetMethodForExecution();

            if (methodInfo == null)
            {
                return new NotFoundResponse();
            }

            this.PrepareParameters(methodInfo);

            var actionResult = (IInvocable)this.GetMethodForExecution().Invoke(this.GetController(), this.methodParams);

            var content = actionResult.Invoke();

            IHttpResponse response = new ContentResponse(HttpStatusCode.Ok, content);

            return response;
        }

        private void PrepareParameters(MethodInfo methodInfo)
        {
            IEnumerable<ParameterInfo> parameters = methodInfo.GetParameters();

            this.methodParams = new object[parameters.Count()];

            var index = 0;

            foreach (var param in parameters)
            {
                if (param.ParameterType.IsPrimitive || param.ParameterType == typeof(string))
                {
                    var value = this.getParams[param.Name];

                    this.methodParams[index] = Convert.ChangeType(value, param.ParameterType);

                    index++;
                }
                else
                {
                    var bindingModelType = param.ParameterType;

                    var bindingModel = Activator.CreateInstance(bindingModelType);

                    IEnumerable<PropertyInfo> properties = bindingModelType.GetProperties();

                    foreach (var property in properties)
                    {
                        property.SetValue(bindingModel, Convert.ChangeType(postParams[property.Name], property.PropertyType));
                    }

                    this.methodParams[index] = Convert.ChangeType(bindingModel, bindingModelType);

                    index++;
                }
            }
        }

        private MethodInfo GetMethodForExecution()
        {
            MethodInfo method = null;

            foreach (var methodInfo in this.GetSuitableMethods())
            {
                var attributes = methodInfo.GetCustomAttributes().Where(a => a is HttpMethodAttribute).Cast<HttpMethodAttribute>();

                if (!attributes.Any() && this.requestMethod.Equals("GET"))
                {
                    return methodInfo;
                }

                foreach (var attribute in attributes)
                {
                    if (attribute.IsValid(this.requestMethod))
                    {
                        return methodInfo;
                    }
                }
            }

            return method;
        }

        private IEnumerable<MethodInfo> GetSuitableMethods()
        {
            var controller = this.GetController();

            if (controller == null)
            {
                return new MethodInfo[0];
            }

            return this.GetController().GetType().GetMethods().Where(m => m.Name.Equals(this.actionName));
        }

        private Controller GetController()
        {
            var controllerFullQualifiedName = string.Format($"{MvcContext.Get.AssemblyName}.{MvcContext.Get.ControllersFolder}.{this.controllerName}, {MvcContext.Get.AssemblyName}");

            var type = Type.GetType(controllerFullQualifiedName);

            if (type == null)
            {
                return null;
            }

            var controller = (Controller)Activator.CreateInstance(type);

            return controller;
        }
    }
}
