using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class Offer
    {
        [Required]
        [Key]
        public string Id { get; set; }
        public string Vendor { get; set; }
        public string VendorCode { get; set; }
        public int CBid { get; set; }
        public int Bid { get; set; }
        [Required]
        public Uri Url { get; set; }
        [Required]
        public float Price { get; set; }
        public float OldPrice { get; set; }
        public bool EnableAutoDiscounts { get; set; }
        [Required]
        public string CurrencyId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public Uri Picture { get; set; }
        public int 
    }
}
