using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class TblBunny
    {
        public TblBunny()
        {
            TblBunnyDetails = new HashSet<TblBunnyDetail>();
        }

        public string Breed { get; set; }
        public string WeightLbs { get; set; }
        public string LengthInches { get; set; }
        public string Lifespan { get; set; }
        public string Origin { get; set; }
        public string Domesticated { get; set; }
        public string Temperment { get; set; }

        public virtual ICollection<TblBunnyDetail> TblBunnyDetails { get; set; }
    }
}
