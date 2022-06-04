using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class TblPublicSafety
    {
        public TblPublicSafety()
        {
            TblIncidents = new HashSet<TblIncident>();
        }

        public short PsafetyId { get; set; }
        public string PGender { get; set; }
        public string Badge { get; set; }
        public string PName { get; set; }

        public virtual ICollection<TblIncident> TblIncidents { get; set; }
    }
}
