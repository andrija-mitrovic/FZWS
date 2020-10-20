using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FZWS.Core.Models.Sifarnici
{
    [Serializable, XmlRoot(ElementName = "SifarnikProizvodjac")]
    public class ProizvodjacResponse : List<Proizvodjac>
    {
    }

    [Serializable, XmlType("Proizvodjac")]
    public class Proizvodjac
    {
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Datum { get; set; }
    }
}
