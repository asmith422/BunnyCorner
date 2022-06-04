using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class VwBunnyForSale
    {
        [Display(Name = "Bunny Name")]
        public string BunnyName { get; set; }
        [Display(Name = "Breeder Last Name")]
        public string BreederLastName { get; set; }
        [Display(Name = "Bunny Breed")]
        public string Breed { get; set; }
        [Display(Name = "Price (USD)")]
        public int? Price { get; set; }
        [Display(Name = "Breeder State")]
        public string State { get; set; }
        [Display(Name = "Breeder Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
