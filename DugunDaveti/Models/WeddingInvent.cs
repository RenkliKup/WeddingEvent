using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DugunDaveti.Models
{
    public class WeddingInvent
    {

        public int id { get; set; } = 0;
        [Required(ErrorMessage = "Ad Alanını girmelisin")]
        public string name { get; set; } = null;
        [Required(ErrorMessage = "Soyad Alanını girmelisin")]
        public string surname { get; set; } = null;
        
        [EmailAddress(ErrorMessage = "E-Mail Alanını girmelisin")]
        [Required(ErrorMessage = "E posta alanı boş olamaz")]
        public string Mail { get; set; } = null;
        [Required(ErrorMessage = "E-Mail Alanını girmelisin")]
        public string TelNo { get; set; } = null;
        public bool isAttend { get; set; } = false;
        [Required(ErrorMessage = "Lütfen güzel mesajlarınızı bizdene esirgemeyin")]
        public string message { get; set; } = "";
        
      

    }
}
