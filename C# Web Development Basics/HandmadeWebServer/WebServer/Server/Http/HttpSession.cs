using System.Collections.Generic;
using System.Linq;
using WebServer.Server.Http.Contracts;

namespace WebServer.Server.Http
{
    public class HttpSession : IHttpSession
    {
        private string id;
        private Dictionary<string, string> parameters;

        public HttpSession(string id)
        {
            this.parameters = new Dictionary<string, string>();
            this.id = id;
        }

        public string Id => this.id;

        public void Add(string key, string value)
        {
            this.parameters[key] = value;
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public string GetParameter(string key)
        {
            return this.parameters.FirstOrDefault(p => p.Key.Equals(key)).Value;
        }

        public bool IsAuthenticated()
        {
            throw new System.NotImplementedException();
        }
    }
}
