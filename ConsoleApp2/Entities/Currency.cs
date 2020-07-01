using System;
using System.Xml.Serialization;

namespace ConsoleApp2.Entities
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class Currency
    {

        private string idField;

        private byte rateField;

        private byte plusField;

        [XmlAttribute("id")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [XmlAttribute("rate")]
        public byte Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        [XmlAttribute("plus")]
        public byte Plus
        {
            get
            {
                return this.plusField;
            }
            set
            {
                this.plusField = value;
            }
        }
    }
}
