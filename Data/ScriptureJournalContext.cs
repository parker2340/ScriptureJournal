using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

    public class ScriptureJournalContext : DbContext
    {
        public ScriptureJournalContext (DbContextOptions<ScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Scriptures>? Scriptures { get; set; }
    }
