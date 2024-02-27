using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sauna.Data;
using Sauna.Models;

namespace Sauna.Pages.BookedTimes
{
    public class EditModel : PageModel
    {
        private readonly Sauna.Data.SaunaContext _context;

        public EditModel(Sauna.Data.SaunaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BookedTime BookedTime { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BookedTimes == null)
            {
                return NotFound();
            }

            var bookedtime =  await _context.BookedTimes.FirstOrDefaultAsync(m => m.Id == id);
            if (bookedtime == null)
            {
                return NotFound();
            }
            BookedTime = bookedtime;
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

            _context.Attach(BookedTime).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookedTimeExists(BookedTime.Id))
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

        private bool BookedTimeExists(int id)
        {
          return (_context.BookedTimes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
