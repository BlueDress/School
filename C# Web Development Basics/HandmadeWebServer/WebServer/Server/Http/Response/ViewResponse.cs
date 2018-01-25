using System;
using WebServer.Server.Contracts;
using WebServer.Server.Enums;

namespace WebServer.Server.Http.Response
{
    public class ViewResponse : HttpResponse
    {
        private readonly IView view;

        public ViewResponse(HttpStatusCode statusCode, IView view) 
        {
            this.ValidateStatusCode(statusCode);

            this.view = view;
            this.StatusCode = statusCode;
        }

        private void ValidateStatusCode(HttpStatusCode statusCode)
        {

            if (299 < (int)this.StatusCode && (int)this.StatusCode < 400)
            {
                throw new InvalidOperationException("Need status code between 300 and 400");
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}{this.view.View()}";
        }
    }
}
