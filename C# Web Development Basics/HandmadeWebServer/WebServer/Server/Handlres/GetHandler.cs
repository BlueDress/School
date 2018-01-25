using System;
using WebServer.Server.Handlres.Contracts;
using WebServer.Server.Http.Contracts;

namespace WebServer.Server.Handlres
{
    public class GetHandler : RequestHandler
    {
        public GetHandler(Func<IHttpRequest, IHttpResponse> handlingFunc) : base(handlingFunc)
        {

        }
    }
}
