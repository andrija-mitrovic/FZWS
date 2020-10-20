using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FZWS.Core.Models.Sifarnici
{
    [Serializable, XmlRoot(ElementName = "SifarnikUstanova")]
    public class UstanoveResponse : List<Ustanova>
    {
    }

    [Serializable, XmlType("Ustanova")]
    public class Ustanova
    {
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Datum { get; set; }
        public int Status { get; set; }
    }
}
