using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOPlatform.Core
{
    public class HttpBuilder
    {
        
        const string HttpMethod = "GET";
        const string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36";
        public HttpRequest _HttpRequest { get; set; }
        public Boolean UseProxy { get; set; }

        private String _GetProxy { get { return ""; } }
        private ProxyType _GetProxyType
        {
            get
            {
                return ProxyType.Socks5;
            }
        }
        public    HttpBuilder()
        {
            _HttpRequest = new HttpRequest();
          
        }


        public void _CreateBuilder()
        {
            if(UseProxy == true)
            {
                _HttpRequest.Proxy = ProxyClient.Parse(_GetProxyType, _GetProxy);
            }
            _HttpRequest["Accept"] = "*/*";
            _HttpRequest.UserAgent = UserAgent;
        }

        public HttpRequest _BuildRequst()
        {
            return _HttpRequest;
        }

    }
}
