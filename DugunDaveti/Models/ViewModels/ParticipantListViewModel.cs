using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DugunDaveti.Models.ViewModels
{
    public class ParticipantListViewModel
    {
        
        public IEnumerable<WeddingInvent> weddingInvents { get; set; }
        public PageingInfo PageingInfo { get; set; }
        public string currentCategory { get; set; }
    }
}
