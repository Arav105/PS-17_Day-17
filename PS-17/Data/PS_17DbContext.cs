using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PS_17.Model;

namespace PS_17.Data
{
    public class PS_17DbContext : DbContext
    {
        public PS_17DbContext (DbContextOptions<PS_17DbContext> options)
            : base(options)
        {
        }

        public DbSet<PS_17.Model.Movies> Movies { get; set; } = default!;
    }
}
