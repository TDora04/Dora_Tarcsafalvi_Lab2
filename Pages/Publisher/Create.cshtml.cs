﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dora_Tarcsafalvi_Lab2.Data;
using Dora_Tarcsafalvi_Lab2.Models;

namespace Dora_Tarcsafalvi_Lab2.Pages.Publisher
{
    public class CreateModel : PageModel
    {
        private readonly Dora_Tarcsafalvi_Lab2.Data.Dora_Tarcsafalvi_Lab2Context _context;

        public CreateModel(Dora_Tarcsafalvi_Lab2.Data.Dora_Tarcsafalvi_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publisher == null || Publisher == null)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
