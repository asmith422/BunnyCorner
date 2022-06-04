using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectSmithAshley
{
    public partial class TblDriver
    {
        public TblDriver()
        {
            TblTickets = new HashSet<TblTicket>();
        }

        public int Driverid { get; set; }
        public string Dname { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Dstate { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<TblTicket> TblTickets { get; set; }
    }
}
