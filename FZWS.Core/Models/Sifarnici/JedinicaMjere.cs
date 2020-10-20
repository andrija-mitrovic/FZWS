using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FZWS.Core.Models.Sifarnici
{
    [Serializable, XmlRoot(ElementName = "SifarnikJedinicaMjere")]
    public class JedinicaMjereResponse : List<JedinicaMjere>
    {
    }

    [Serializable, XmlType("JedinicaMjere")]
    public class JedinicaMjere
    {
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Datum { get; set; }
    }
}
