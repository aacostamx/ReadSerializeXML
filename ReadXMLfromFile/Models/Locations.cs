using System.Collections.Generic;
using System.Xml.Serialization;

namespace ReadXMLfromFile.Models
{
    public class Location
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        public List<Building> Buildings { get; set; }
    }
}
