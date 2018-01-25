using System.Collections.Generic;

namespace WebServer.Server.Http.Contracts
{
    public interface IHttpHeaderCollection
    {
        void Add(HttpHeader header);

        bool ContainsKey(string key);

        List<HttpHeader> GetHeader(string key);
    }
}
