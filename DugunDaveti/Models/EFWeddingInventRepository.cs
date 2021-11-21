using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DugunDaveti.Models;

namespace DugunDaveti.Models
{
    public class EFWeddingInventRepository : IWeddingRepository
    {
        private WeddingInventDbContext dbContext;
        public EFWeddingInventRepository(WeddingInventDbContext ctx)
        {
            dbContext = ctx;
        }

        public IQueryable<WeddingInvent> weddingInvents => dbContext.weddingInvents.AsQueryable();

        public void saveInvents(WeddingInvent invent)
        {
            dbContext.Add(invent);
            dbContext.SaveChanges();
        }

       
    }
}
