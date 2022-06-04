using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class TblPetDetail
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string Type { get; set; }
        public string Breed { get; set; }
        public string Sex { get; set; }
        public DateTime? Dob { get; set; }
        public int? Price { get; set; }
        public string PetNotes { get; set; }
        public int? OwnerId { get; set; }

        public virtual TblOwnerDetail Owner { get; set; }
    }
}
