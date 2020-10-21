using FZWS.Core.Helpers;
using FZWS.Core.Models.Lager;
using FZWS.Core.Models.Sifarnici;
using FZWS.Core.Proxy;
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

        private readonly FZWSConfig _config;
        private readonly LagerProxy _lagerProxy;
        private readonly SifarniciProxy _sifarniciProxy;

        public FZWSClient(FZWSConfig config)
        {
            _config = config;
            _config.LagerUrl = URL_LAGER;
            _config.SifarniciUrl = URL_SIFARNICI;

            _lagerProxy = new LagerProxy(config);
            _sifarniciProxy = new SifarniciProxy(config);
        }

        public IList<Ustanova> GetUstanove()
        {
            var xml = _sifarniciProxy.Sifarnici(_config.UstanoveId, "Ustanova", "");
            var data = SerializationHelper.XmlStringToData<UstanoveResponse>(xml);

            return data;
        }
        
        public IList<OrganizacionaJedinica> GetOrganizacioneJedinice()
        {
            var xml = _sifarniciProxy.Sifarnici(_config.UstanoveId, "OrganizacionaJedinica", "");
            var data = SerializationHelper.XmlStringToData<OrganizacionaJedinicaResponse>(xml);

            return data;
        }

        public IList<JedinicaMjere> GetJediniceMjere()
        {
            var xml = _sifarniciProxy.Sifarnici(_config.UstanoveId, "JedinicaMjere", "");
            var data = SerializationHelper.XmlStringToData<JedinicaMjereResponse>(xml);

            return data;
        }

        public IList<LijekoviLager> GetLijekoviLager()
        {
            var xml = _sifarniciProxy.Sifarnici(_config.UstanoveId, "LijekoviLager", "");
            var data = SerializationHelper.XmlStringToData<LijekoviLagerResponse>(xml);

            return data;
        }

        public IList<Proizvodjac> GetProizvodajci()
        {
            var xml = _sifarniciProxy.Sifarnici(_config.UstanoveId, "Proizvodjac", "");
            var data = SerializationHelper.XmlStringToData<ProizvodjacResponse>(xml);

            return data;
        }

        public IList<LagerResponse> SendLager(PostLagerRequest requestModel)
        {
            var xml = SerializationHelper.DataToXmlString(requestModel);
            var response = _lagerProxy.getLager(xml);
            var result = SerializationHelper.XmlStringToData<PostLagerResponse>(response);

            return result;
        }
    }
}
