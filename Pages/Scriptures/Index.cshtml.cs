using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ScriptureJournal.Pages_Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournalContext _context;

        public IndexModel(ScriptureJournalContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Book { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string Note { get; set; }
        

        public IList<Scriptures> Scriptures { get;set; } = default!;

        public async Task OnGetAsync()
            {
                var scriptures = from m in _context.Scriptures
                            select m;
                if (!string.IsNullOrEmpty(SearchString))
                {
                    scriptures = scriptures.Where(s => (s.Book.Contains(SearchString)) || (s.Notes.Contains(SearchString)));
                }



                Scriptures = await scriptures.ToListAsync();
    }
    }
}
