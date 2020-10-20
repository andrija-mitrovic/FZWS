using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FZWS.Core
{
    public class FZWSConfig
    {
        public string SifraUstanove { get; set; }
        public string OrgJedinicaId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LagerUrl { get; set; }
        public string SifarniciUrl { get; set; }

        public void AddAuthHeader(HttpWebRequest request)
        {
            String encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + Password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
    }
}
