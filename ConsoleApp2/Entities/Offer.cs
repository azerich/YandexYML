using ConsoleApp2.Enums;
using System;
using System.Xml.Serialization;

namespace ConsoleApp2.Entities
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class Offer
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private ushort idField;

        private string typeField;

        private byte bidField;

        private byte cbidField;

        private bool cbidFieldSpecified;

        private bool availableField;

        [XmlElement("ISBN", typeof(string))]
        [XmlElement("artist", typeof(string))]
        [XmlElement("author", typeof(string))]
        [XmlElement("binding", typeof(string))]
        [XmlElement("categoryId", typeof(CategoryId))]
        [XmlElement("country", typeof(string))]
        [XmlElement("country_of_origin", typeof(string))]
        [XmlElement("currencyId", typeof(string))]
        [XmlElement("dataTour", typeof(string))]
        [XmlElement("date", typeof(string))]
        [XmlElement("days", typeof(byte))]
        [XmlElement("delivery", typeof(bool))]
        [XmlElement("description", typeof(string))]
        [XmlElement("director", typeof(string))]
        [XmlElement("downloadable", typeof(bool))]
        [XmlElement("format", typeof(string))]
        [XmlElement("hall", typeof(Hall))]
        [XmlElement("hall_part", typeof(string))]
        [XmlElement("hotel_stars", typeof(string))]
        [XmlElement("included", typeof(string))]
        [XmlElement("is_kids", typeof(byte))]
        [XmlElement("is_premiere", typeof(byte))]
        [XmlElement("language", typeof(string))]
        [XmlElement("local_delivery_cost", typeof(ushort))]
        [XmlElement("manufacturer_warranty", typeof(bool))]
        [XmlElement("meal", typeof(string))]
        [XmlElement("media", typeof(string))]
        [XmlElement("model", typeof(string))]
        [XmlElement("name", typeof(string))]
        [XmlElement("originalName", typeof(string))]
        [XmlElement("page_extent", typeof(ushort))]
        [XmlElement("part", typeof(byte))]
        [XmlElement("performance_type", typeof(string))]
        [XmlElement("performed_by", typeof(string))]
        [XmlElement("picture", typeof(string))]
        [XmlElement("place", typeof(string))]
        [XmlElement("price", typeof(ushort))]
        [XmlElement("publisher", typeof(string))]
        [XmlElement("recording_length", typeof(string))]
        [XmlElement("region", typeof(string))]
        [XmlElement("room", typeof(string))]
        [XmlElement("series", typeof(string))]
        [XmlElement("starring", typeof(string))]
        [XmlElement("storage", typeof(string))]
        [XmlElement("title", typeof(string))]
        [XmlElement("transport", typeof(string))]
        [XmlElement("typePrefix", typeof(string))]
        [XmlElement("url", typeof(string))]
        [XmlElement("vendor", typeof(string))]
        [XmlElement("vendorCode", typeof(string))]
        [XmlElement("volume", typeof(byte))]
        [XmlElement("worldRegion", typeof(string))]
        [XmlElement("year", typeof(ushort))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [XmlAttribute("id")]
        public ushort Id
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

        [XmlAttribute("type")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        [XmlAttribute("bid")]
        public byte Bid
        {
            get
            {
                return this.bidField;
            }
            set
            {
                this.bidField = value;
            }
        }

        [XmlAttribute("cbid")]
        public byte CBid
        {
            get
            {
                return this.cbidField;
            }
            set
            {
                this.cbidField = value;
            }
        }

        [XmlIgnore()]
        public bool CBidSpecified
        {
            get
            {
                return this.cbidFieldSpecified;
            }
            set
            {
                this.cbidFieldSpecified = value;
            }
        }

        [XmlAttribute("available")]
        public bool Available
        {
            get
            {
                return this.availableField;
            }
            set
            {
                this.availableField = value;
            }
        }
    }
}
