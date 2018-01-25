using SimpleMvc.Framework.Attributes.Method;

namespace SimpleMvc.Framework.Attributes
{
    public class HttpGetAttribute : HttpMethodAttribute
    {
        public override bool IsValid(string requestMethod)
        {
            if (requestMethod.ToUpper().Equals("GET"))
            {
                return true;
            }

            return false;
        }
    }
}
