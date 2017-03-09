using System.Collections.Generic;
using System.Xml.Serialization;

namespace ReadXMLfromFile.Models
{
    [XmlRoot("info")]
    public class Info
    {
        [XmlArray("locations")]
        [XmlArrayItem("location")]
        public List<Location> Locations { get; set; }
    }
}
