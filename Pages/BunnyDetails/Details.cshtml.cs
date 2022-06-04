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
    public class DetailsModel : PageModel
    {
        private readonly FinalProjectSmithAshley.ASmith53Context _context;

        public DetailsModel(FinalProjectSmithAshley.ASmith53Context context)
        {
            _context = context;
        }

        public TblBunnyDetail TblBunnyDetail { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblBunnyDetail = await _context.TblBunnyDetails
                .Include(t => t.BreedNavigation)
                .Include(t => t.BreederLastNameNavigation).FirstOrDefaultAsync(m => m.BunnyName == id);

            if (TblBunnyDetail == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
