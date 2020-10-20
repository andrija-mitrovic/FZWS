using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FZWS.Core.Proxy
{
    public class SifarniciProxy:getSifarnici
    {
        private readonly FZWSConfig _config;

        public SifarniciProxy(FZWSConfig config)
        {
            Url = config.SifarniciUrl;
            _config = config;
        }

        protected override WebRequest GetWebRequest(Uri uri)
        {
            HttpWebRequest request = (HttpWebRequest)base.GetWebRequest(uri);
            _config.AddAuthHeader(request);
            return request;
        }
    }
}
