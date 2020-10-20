using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FZWS.Core.Models.Sifarnici
{
    [Serializable, XmlRoot(ElementName = "SifarnikOrganizacionaJedinica")]
    public class OrganizacionaJedinicaResponse : List<OrganizacionaJedinica>
    {
    }

    [Serializable, XmlType("OrganizacionaJedinica")]
    public class OrganizacionaJedinica
    {
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Datum { get; set; }
    }
}
