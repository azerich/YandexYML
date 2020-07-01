using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConsoleApp2.Entities
{
    [Serializable]
    public partial class Shop
    {
        public Shop() { }

        private string nameField;

        private string companyField;

        private string urlField;

        private Currency[] currenciesField;

        private Category[] categoriesField;

        private int localDeliveryCostField;

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

        [XmlArray("currencies")]
        [XmlArrayItem("currency", typeof(Currency))]
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

        [XmlArray("categories")]
        [XmlArrayItem("category", typeof(Category))]
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
        public int LocalDeliveryCost
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
        
        [XmlArray("offers")]
        [XmlArrayItem("offer", typeof(Offer))]
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
