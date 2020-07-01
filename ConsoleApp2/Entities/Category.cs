using System;
using System.Xml.Serialization;

namespace ConsoleApp2.Entities
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class Category
    {

        private byte idField;

        private byte parentIdField;

        private bool parentIdFieldSpecified;

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
                return this.parentIdFieldSpecified;
            }
            set
            {
                this.parentIdFieldSpecified = value;
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
