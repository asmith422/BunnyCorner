using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class TblOwnerDetail
    {
        public TblOwnerDetail()
        {
            TblPetDetails = new HashSet<TblPetDetail>();
        }

        public int OwnerId { get; set; }
        public string OwnerLastName { get; set; }
        public string OwnerFirstName { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<TblPetDetail> TblPetDetails { get; set; }
    }
}
