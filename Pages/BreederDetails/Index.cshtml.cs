using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProjectSmithAshley;

namespace FinalProjectSmithAshley.Pages.BreederDetails
{
    public class IndexModel : PageModel
    {
        private readonly FinalProjectSmithAshley.ASmith53Context _context;

        public IndexModel(FinalProjectSmithAshley.ASmith53Context context)
        {
            _context = context;
        }

        public IList<TblBreederDetail> TblBreederDetail { get;set; }

        public async Task OnGetAsync()
        {
            TblBreederDetail = await _context.TblBreederDetails.ToListAsync();
        }
    }
}
