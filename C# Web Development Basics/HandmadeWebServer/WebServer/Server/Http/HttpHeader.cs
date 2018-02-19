﻿using WebServer.Server.Common;

namespace WebServer.Server.Http
{
    public class HttpHeader
    {
        public HttpHeader(string key, string value)
        {
            NullValidator.ThrowIfNullOrEmpty(key, nameof(key));
            NullValidator.ThrowIfNullOrEmpty(value, nameof(value));

            this.Key = key;
            this.Value = value;
        }

        public string Key { get; private set; }

        public string Value { get; private set; }

        public override string ToString()
        {
            return $"{this.Key}: {this.Value}";
        }
    }
}