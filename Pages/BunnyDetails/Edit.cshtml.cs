using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectSmithAshley;

namespace FinalProjectSmithAshley.Pages.BunnyDetails
{
    public class EditModel : PageModel
    {
        private readonly FinalProjectSmithAshley.ASmith53Context _context;

        public EditModel(FinalProjectSmithAshley.ASmith53Context context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["Breed"] = new SelectList(_context.TblBunnies, "Breed", "Breed");
           ViewData["BreederLastName"] = new SelectList(_context.TblBreederDetails, "BreederLastName", "BreederLastName");
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

            _context.Attach(TblBunnyDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblBunnyDetailExists(TblBunnyDetail.BunnyName))
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

        private bool TblBunnyDetailExists(string id)
        {
            return _context.TblBunnyDetails.Any(e => e.BunnyName == id);
        }
    }
}
