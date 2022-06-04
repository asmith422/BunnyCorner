using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectSmithAshley.Pages.DataVisualization.MyViews
{
    public class BunniesForSaleModel : PageModel
    {
        private readonly FinalProjectSmithAshley.ASmith53Context _context;
        public BunniesForSaleModel(FinalProjectSmithAshley.ASmith53Context context) 
        { 
            _context = context; 
        }
        public IList<VwBunnyForSale> VwBunnyForSale { get; set; }
        public async Task OnGetAsync() 
        { 
            VwBunnyForSale = await _context.VwBunnyForSales.ToListAsync(); 
        }

    }
}
