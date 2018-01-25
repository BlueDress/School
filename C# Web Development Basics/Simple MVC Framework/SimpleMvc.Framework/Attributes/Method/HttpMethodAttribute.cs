using System;

namespace SimpleMvc.Framework.Attributes.Method
{
    public abstract class HttpMethodAttribute : Attribute
    {
        public abstract bool IsValid(string requestMethod);
    }
}
