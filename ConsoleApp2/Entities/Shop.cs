using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class Shop
    {
        [Required]
        [Key]
        public string Name { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public Uri Url { get; set; }
        public string Platform { get; set; }
        public string Version { get; set; }
        public string Agency { get; set; }
        public string Email { get; set; }
        [Required]
        public List<Currency> Currencies { get; set; }
        [Required]
        public List<Category> Categories { get; set; }
        public List<ShopOptions> DeliveryOptions { get; set; }
        public List<ShopOptions> PickupOptions { get; set; }
        public bool EnableAutoDiscounts { get; set; }
        [Required]
        public List<Offer> Offers { get; set; }
        public List<Gift> Gifts { get; set; }
        public List<Promo> Promos { get; set; }
    }
}
