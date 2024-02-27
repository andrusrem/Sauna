using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sauna.Data;
using Sauna.Models;

namespace Sauna.Pages.BookedTimes
{
    public class DetailsModel : PageModel
    {
        private readonly Sauna.Data.SaunaContext _context;

        public DetailsModel(Sauna.Data.SaunaContext context)
        {
            _context = context;
        }

      public BookedTime BookedTime { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BookedTimes == null)
            {
                return NotFound();
            }

            var bookedtime = await _context.BookedTimes.FirstOrDefaultAsync(m => m.Id == id);
            if (bookedtime == null)
            {
                return NotFound();
            }
            else 
            {
                BookedTime = bookedtime;
            }
            return Page();
        }
    }
}
