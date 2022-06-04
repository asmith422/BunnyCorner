using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class TblIncident
    {
        public short IncidentId { get; set; }
        public DateTime IncidentDate { get; set; }
        public short? StudentId { get; set; }
        public short? FacultyId { get; set; }
        public short PsafetyId { get; set; }
        public short? CarId { get; set; }
        public string Comments { get; set; }

        public virtual TblCar Car { get; set; }
        public virtual TblFaculty Faculty { get; set; }
        public virtual TblPublicSafety Psafety { get; set; }
        public virtual TblStudent Student { get; set; }
    }
}
