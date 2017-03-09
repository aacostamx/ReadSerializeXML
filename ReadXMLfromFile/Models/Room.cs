using System.Xml.Serialization;

namespace ReadXMLfromFile.Models
{
    public class Room
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
