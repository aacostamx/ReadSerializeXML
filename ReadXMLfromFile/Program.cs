using ReadXMLfromFile.Models;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace ReadXMLfromFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReadXMLFile();
            XMLSerializer();

            Console.ReadLine();
        }

        /// <summary>
        /// Serializer XML file.
        /// </summary>
        private static void XMLSerializer()
        {
            var serializer = new XmlSerializer(typeof(Info));
            using (var reader = XmlReader.Create("..\\..\\XML File\\Locations.xml"))
            {
                Info info = (Info)serializer.Deserialize(reader);
                List<Location> locations = info.Locations;
            }
        }

        /// <summary>
        /// Reads the XML file.
        /// </summary>
        private static void ReadXMLFile()
        {
            XmlTextReader reader = new XmlTextReader("..\\..\\XML File\\Locations.xml");

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }

                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);

                        while (reader.MoveToNextAttribute())
                            Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }

            }
        }
    }
}

