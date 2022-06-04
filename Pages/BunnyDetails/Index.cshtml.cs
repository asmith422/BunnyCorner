using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProjectSmithAshley;

namespace FinalProjectSmithAshley.Pages.BunnyDetails
{
    public class IndexModel : PageModel
    {
        private readonly FinalProjectSmithAshley.ASmith53Context _context;

        public IndexModel(FinalProjectSmithAshley.ASmith53Context context)
        {
            _context = context;
        }

        public IList<TblBunnyDetail> TblBunnyDetail { get;set; }

        public async Task OnGetAsync()
        {
            TblBunnyDetail = await _context.TblBunnyDetails
                .Include(t => t.BreedNavigation)
                .Include(t => t.BreederLastNameNavigation).ToListAsync();
        }
    }
}
