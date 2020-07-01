using System;
using System.Xml.Serialization;

namespace ConsoleApp2.Entities
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class Hall
    {

        private string planField;

        private string valueField;

        [XmlAttribute("plan")]
        public string Plan
        {
            get
            {
                return this.planField;
            }
            set
            {
                this.planField = value;
            }
        }

        [XmlText()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
