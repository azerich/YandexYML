using System;
using System.Xml.Serialization;

namespace ConsoleApp2.Entities
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "category", Namespace = "", IsNullable = false)]
    public partial class Category
    {
        public Category() { }


        private byte idField;
        private byte parentIdField;
        private string valueField;

        [XmlAttribute("id")]
        public byte Id
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

        [XmlAttribute("parentId")]
        public byte ParentId
        {
            get
            {
                return this.parentIdField;
            }
            set
            {
                this.parentIdField = value;
            }
        }

        [XmlIgnore()]
        public bool ParentIdSpecified
        {
            get
            {
                if (ParentId != 0) return true;
                else return false;
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
