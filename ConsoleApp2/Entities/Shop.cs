using System.Xml.Serialization;

namespace ConsoleApp2.Entities
{
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class Shop
    {

        private string nameField;

        private string companyField;

        private string urlField;

        private Currency[] currenciesField;

        private Category[] categoriesField;

        private ushort localDeliveryCostField;

        private Offer[] offersField;

        [XmlElement("name")]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlElement("company")]
        public string Company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }
        
        [XmlElement("url")]
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        [XmlElement("currencies")]
        [XmlArrayItem("currency", IsNullable =false)]
        public Currency[] Currencies
        {
            get
            {
                return this.currenciesField;
            }
            set
            {
                this.currenciesField = value;
            }
        }

        [XmlElement("categories")]
        [XmlArrayItem("category", IsNullable = false)]
        public Category[] Categories
        {
            get
            {
                return this.categoriesField;
            }
            set
            {
                this.categoriesField = value;
            }
        }

        [XmlElement("local_delivery_cost")]
        public ushort LocalDeliveryCost
        {
            get
            {
                return this.localDeliveryCostField;
            }
            set
            {
                this.localDeliveryCostField = value;
            }
        }
        [XmlElement("offers")]
        [XmlArrayItem("offer", IsNullable = false)]
        public Offer[] Offers
        {
            get
            {
                return this.offersField;
            }
            set
            {
                this.offersField = value;
            }
        }
    }
}
