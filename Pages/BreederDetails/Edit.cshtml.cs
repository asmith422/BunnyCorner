using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectSmithAshley;

namespace FinalProjectSmithAshley.Pages.BreederDetails
{
    public class EditModel : PageModel
    {
        private readonly FinalProjectSmithAshley.ASmith53Context _context;

        public EditModel(FinalProjectSmithAshley.ASmith53Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TblBreederDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblBreederDetailExists(TblBreederDetail.BreederLastName))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TblBreederDetailExists(string id)
        {
            return _context.TblBreederDetails.Any(e => e.BreederLastName == id);
        }
    }
}
