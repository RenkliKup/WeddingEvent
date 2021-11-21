using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace DugunDaveti.Models
{
    public class WeddingInventDbContext: DbContext
    {
        
        public WeddingInventDbContext(DbContextOptions<WeddingInventDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

       public DbSet<WeddingInvent> weddingInvents { get; set; }
    }
}
