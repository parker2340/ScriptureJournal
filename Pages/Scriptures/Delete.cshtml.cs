using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace ScriptureJournal.Pages_Scriptures
{
    public class DeleteModel : PageModel
    {
        private readonly ScriptureJournalContext _context;

        public DeleteModel(ScriptureJournalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Scriptures Scriptures { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Scriptures == null)
            {
                return NotFound();
            }

            var scriptures = await _context.Scriptures.FirstOrDefaultAsync(m => m.ID == id);

            if (scriptures == null)
            {
                return NotFound();
            }
            else 
            {
                Scriptures = scriptures;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Scriptures == null)
            {
                return NotFound();
            }
            var scriptures = await _context.Scriptures.FindAsync(id);

            if (scriptures != null)
            {
                Scriptures = scriptures;
                _context.Scriptures.Remove(Scriptures);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
