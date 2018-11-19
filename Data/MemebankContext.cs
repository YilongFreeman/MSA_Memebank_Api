using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace Memebank.Models
{
    public class MemebankContext : DbContext
    {
        public MemebankContext (DbContextOptions<MemebankContext> options)
            : base(options)
        {
        }

        public DbSet<Memebank.Models.MemeItem> MemeItem { get; set; }
    }
}
