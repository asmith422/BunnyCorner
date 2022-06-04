using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class TblBreederDetail
    {
        public TblBreederDetail()
        {
            TblBunnyDetails = new HashSet<TblBunnyDetail>();
        }

        public string BreederFirstName { get; set; }
        public string BreederLastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public int? Rating { get; set; }

        public virtual ICollection<TblBunnyDetail> TblBunnyDetails { get; set; }
    }
}
