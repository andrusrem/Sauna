using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sauna.Data;
using Sauna.Models;

namespace Sauna.Pages.BookedTimes
{
    public class CreateModel : PageModel
    {
        private readonly Sauna.Data.SaunaContext _context;

        public CreateModel(Sauna.Data.SaunaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BookedTime BookedTime { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.BookedTimes == null || BookedTime == null)
            {
                return Page();
            }

            _context.BookedTimes.Add(BookedTime);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
