using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DugunDaveti.Models
{
    public interface IWeddingRepository
    {
        IQueryable<WeddingInvent> weddingInvents { get; }
        void saveInvents(WeddingInvent invent);
    }
}
