using System;
using WebServer.Server.Common;
using WebServer.Server.Handlres.Contracts;
using WebServer.Server.Http;
using WebServer.Server.Http.Contracts;

namespace WebServer.Server.Handlres
{
    public abstract class RequestHandler : IRequestHandler
    {
        private readonly Func<IHttpRequest, IHttpResponse> handlingFunc;

        public RequestHandler(Func<IHttpRequest, IHttpResponse> handlingFunc)
        {
            NullValidator.ThrowIfNull(handlingFunc, nameof(handlingFunc));

            this.handlingFunc = handlingFunc;
        }

        public IHttpResponse Handle(IHttpContext context)
        {
            var response = this.handlingFunc(context.Request);

            response.HeaderCollection.Add(new HttpHeader("Content-Type", "text/plain"));

            return response;
        }

        private void SetCookies(IHttpContext context, IHttpResponse response)
        {
            var cookies = context.Request.CookieCollection;

            foreach (var cookie in cookies)
            {
                if (cookie.IsNew)
                {
                    response.HeaderCollection.Add(new HttpHeader("Set-Cookie", cookie.ToString()));
                }
            }
        }
    }
}
