using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class TblBunnyDetail
    {
        public string BunnyName { get; set; }
        public string BreederLastName { get; set; }
        public string Breed { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }
        public DateTime? Dob { get; set; }
        public int? Price { get; set; }
        public string Notes { get; set; }

        public virtual TblBunny BreedNavigation { get; set; }
        public virtual TblBreederDetail BreederLastNameNavigation { get; set; }
    }
}
