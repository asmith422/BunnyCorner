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
    public class DeleteModel : PageModel
    {
        private readonly FinalProjectSmithAshley.ASmith53Context _context;

        public DeleteModel(FinalProjectSmithAshley.ASmith53Context context)
        {
            _context = context;
        }

        [BindProperty]
        public TblBunny TblBunny { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblBunny = await _context.TblBunnies.FirstOrDefaultAsync(m => m.Breed == id);

            if (TblBunny == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblBunny = await _context.TblBunnies.FindAsync(id);

            if (TblBunny != null)
            {
                _context.TblBunnies.Remove(TblBunny);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
