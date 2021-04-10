﻿using System;
using System.Xml.Serialization;

namespace IButantan.Wingbank.PackageGenerator
{
    [Serializable]
    public class Author
    {
        [XmlElement("FirstName")]
        public string FirstName { get; set; }

        [XmlElement("LastName")]
        public string LastName { get; set; }
    }
}