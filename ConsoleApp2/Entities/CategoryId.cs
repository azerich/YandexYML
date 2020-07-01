using System;
using System.Xml.Serialization;

namespace ConsoleApp2.Entities
{
    [XmlRoot("categoryId")]
    public partial class CategoryId
    {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlText()]
        public byte Value { get; set; }
    }
}
