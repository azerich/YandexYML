using System;
using System.Xml.Serialization;

namespace ConsoleApp2.Entities
{
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName ="yml_catalog", Namespace = "", IsNullable = false)]
    public partial class Catalog
    {
        public Catalog() { }

        private Shop shopField;
        private string dateField;
        
        [XmlElement("shop")]
        public Shop Shop
        {
            get
            {
                return this.shopField;
            }
            set
            {
                this.shopField = value;
            }
        }

        [XmlAttribute("date")]
        public string Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }
}
