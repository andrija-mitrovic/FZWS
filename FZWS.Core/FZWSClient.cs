using FZWS.Core.Models.Sifarnici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZWS.Core
{
    public class FZWSClient
    {
        private const string URL_SIFARNICI = "https://trust1.fzocg.net:443/wspaZalihe/getSifarnici";
        private const string URL_LAGER = "https://trust1.fzocg.net:443/wspaZalihe/prijemLagera";

        private readonly FZWSConfig _FZWSConfig;

        public FZWSClient(FZWSConfig FZWSConfig)
        {
            _FZWSConfig = FZWSConfig;
            _FZWSConfig.LagerUrl = URL_LAGER;
            _FZWSConfig.SifarniciUrl = URL_SIFARNICI;
        }


        
    }
}
