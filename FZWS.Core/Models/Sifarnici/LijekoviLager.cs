﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FZWS.Core.Models.Sifarnici
{
    [Serializable, XmlRoot(ElementName = "SifarnikLijekoviLager")]
    public class LijekoviLagerResponse : List<LijekoviLager>
    {

    }

    [Serializable, XmlType("LijekoviLager")]
    public class LijekoviLager
    {
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Datum { get; set; }
        public int RBr { get; set; }
        public string JMPak { get; set; }
        public string Proizv { get; set; }
    }
}
