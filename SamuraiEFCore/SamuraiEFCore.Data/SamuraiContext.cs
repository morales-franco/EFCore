using Microsoft.EntityFrameworkCore;
using SamuraiEFCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiEFCore.Data
{
    public class SamuraiContext: DbContext
    {
        public SamuraiContext(DbContextOptions<SamuraiContext> options)
            : base(options) { }

        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }
    }
}
