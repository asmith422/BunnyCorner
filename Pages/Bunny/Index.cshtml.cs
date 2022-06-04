using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProjectSmithAshley;

namespace FinalProjectSmithAshley.Pages.Bunny
{
    public class IndexModel : PageModel
    {
        private readonly FinalProjectSmithAshley.ASmith53Context _context;

        public IndexModel(FinalProjectSmithAshley.ASmith53Context context)
        {
            _context = context;
        }

        public IList<TblBunny> TblBunny { get;set; }

        public async Task OnGetAsync()
        {
            TblBunny = await _context.TblBunnies.ToListAsync();
        }
    }
}
