﻿using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace IButantan.Wingbank.PackageGenerator
{
    [Serializable]
    public class Colony
    {
        [XmlElement("ColonyId")]
        public string ColonyId { get; set; }

        [XmlElement("TemperatureControl")]
        public string TemperatureControl { get; set; }

        [XmlElement("RelaviteHumidity")]
        public string RelaviteHumidity { get; set; }

        [XmlElement("Strain")]
        public string Strain { get; set; }

        [XmlElement("Note")]
        public XmlCDataSection Note { get; set; }
    }
}