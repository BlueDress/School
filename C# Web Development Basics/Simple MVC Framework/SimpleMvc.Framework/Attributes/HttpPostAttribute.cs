﻿using SimpleMvc.Framework.Attributes.Method;

namespace SimpleMvc.Framework.Attributes
{
    public class HttpPostAttribute : HttpMethodAttribute
    {
        public override bool IsValid(string requestMethod)
        {
            if (requestMethod.ToUpper().Equals("POST"))
            {
                return true;
            }

            return false;
        }
    }
}
