using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProjectSmithAshley;

namespace FinalProjectSmithAshley.Pages.BunnyDetails
{
    public class CreateModel : PageModel
    {
        private readonly FinalProjectSmithAshley.ASmith53Context _context;

        public CreateModel(FinalProjectSmithAshley.ASmith53Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Breed"] = new SelectList(_context.TblBunnies, "Breed", "Breed");
        ViewData["BreederLastName"] = new SelectList(_context.TblBreederDetails, "BreederLastName", "BreederLastName");
            return Page();
        }

        [BindProperty]
        public TblBunnyDetail TblBunnyDetail { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblBunnyDetails.Add(TblBunnyDetail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
