using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AmoCSHARP.Models;

namespace AmoCSHARP.Data
{
    public class AmoCSHARPContext : DbContext
    {
        public AmoCSHARPContext (DbContextOptions<AmoCSHARPContext> options)
            : base(options)
        {
        }

        public DbSet<AmoCSHARP.Models.Produto> Produto { get; set; } = default!;
    }
}
