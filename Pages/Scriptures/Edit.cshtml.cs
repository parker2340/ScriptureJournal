using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace ScriptureJournal.Pages_Scriptures
{
    public class EditModel : PageModel
    {
        private readonly ScriptureJournalContext _context;

        public EditModel(ScriptureJournalContext context)
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

            var scriptures =  await _context.Scriptures.FirstOrDefaultAsync(m => m.ID == id);
            if (scriptures == null)
            {
                return NotFound();
            }
            Scriptures = scriptures;
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

            _context.Attach(Scriptures).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScripturesExists(Scriptures.ID))
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

        private bool ScripturesExists(int id)
        {
          return (_context.Scriptures?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
