using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class TblStudent
    {
        public TblStudent()
        {
            TblIncidents = new HashSet<TblIncident>();
        }

        public short StudentId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string Major { get; set; }
        public short? CarId { get; set; }

        public virtual TblCar Car { get; set; }
        public virtual ICollection<TblIncident> TblIncidents { get; set; }
    }
}
