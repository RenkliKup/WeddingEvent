using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DugunDaveti.Models
{
    public class Repository
    {
       public static List<WeddingInvent> repository = new List<WeddingInvent>();
        public IEnumerable<WeddingInvent> Repositories()
        {
            return repository;
        }

        public void addRepo(WeddingInvent repo)
        {
            repository.Add(repo);
        }

    }
}
