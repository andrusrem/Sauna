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
    public class IndexModel : PageModel
    {
        private readonly Sauna.Data.SaunaContext _context;

        public IndexModel(Sauna.Data.SaunaContext context)
        {
            _context = context;
        }

        public IList<BookedTime> BookedTime { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.BookedTimes != null)
            {
                BookedTime = await _context.BookedTimes.ToListAsync();
            }
        }
    }
}
