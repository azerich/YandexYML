using System.Xml.Serialization;

namespace ConsoleApp2.Entities
{
    [XmlRoot("hall")]
    public class Hall
    {
        [XmlAttribute("plan")]
        public string Plan { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
