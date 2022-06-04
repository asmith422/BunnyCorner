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
    public class DeleteModel : PageModel
    {
        private readonly FinalProjectSmithAshley.ASmith53Context _context;

        public DeleteModel(FinalProjectSmithAshley.ASmith53Context context)
        {
            _context = context;
        }

        [BindProperty]
        public TblBreederDetail TblBreederDetail { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblBreederDetail = await _context.TblBreederDetails.FirstOrDefaultAsync(m => m.BreederLastName == id);

            if (TblBreederDetail == null)
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

            TblBreederDetail = await _context.TblBreederDetails.FindAsync(id);

            if (TblBreederDetail != null)
            {
                _context.TblBreederDetails.Remove(TblBreederDetail);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
