using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class TblFaculty
    {
        public TblFaculty()
        {
            TblIncidents = new HashSet<TblIncident>();
        }

        public short FacultyId { get; set; }
        public string FacName { get; set; }
        public string FacGender { get; set; }
        public DateTime? HireDate { get; set; }
        public short? CarId { get; set; }

        public virtual TblCar Car { get; set; }
        public virtual ICollection<TblIncident> TblIncidents { get; set; }
    }
}
