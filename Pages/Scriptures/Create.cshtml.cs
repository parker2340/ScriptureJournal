using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Models;

namespace ScriptureJournal.Pages_Scriptures
{
    public class CreateModel : PageModel
    {
        private readonly ScriptureJournalContext _context;

        public CreateModel(ScriptureJournalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Scriptures Scriptures { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Scriptures == null || Scriptures == null)
            {
                return Page();
            }

            _context.Scriptures.Add(Scriptures);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
