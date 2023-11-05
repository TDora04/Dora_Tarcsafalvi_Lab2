using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dora_Tarcsafalvi_Lab2.Data;
using Dora_Tarcsafalvi_Lab2.Models;

namespace Dora_Tarcsafalvi_Lab2.Pages.Publisher
{
    public class IndexModel : PageModel
    {
        private readonly Dora_Tarcsafalvi_Lab2.Data.Dora_Tarcsafalvi_Lab2Context _context;
        private readonly object await_context;

        public IndexModel(Dora_Tarcsafalvi_Lab2.Data.Dora_Tarcsafalvi_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
