using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ReadXMLfromFile.Models
{
    public class Building
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
