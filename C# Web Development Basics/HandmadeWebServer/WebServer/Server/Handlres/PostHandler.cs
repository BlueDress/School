using System;
using WebServer.Server.Handlres.Contracts;
using WebServer.Server.Http.Contracts;

namespace WebServer.Server.Handlres
{
    public class PostHandler : RequestHandler
    {
        public PostHandler(Func<IHttpRequest, IHttpResponse> handlingFunc) : base(handlingFunc)
        {

        }
    }
}
