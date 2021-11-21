using DugunDaveti.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace DugunDaveti.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Repository new1 = new Repository();
        IWeddingRepository db;
        
       
        
        public HomeController(IWeddingRepository _db)
        {
            db = _db;
            
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(WeddingInvent invent)
        {
            if(ModelState.IsValid)
            {
                db.saveInvents(invent);
                
                return View("isInvent",invent);
            }

            return View();
            
        }

        public IActionResult Privacy()
        {
          
            return View("Privacy",db.weddingInvents.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }
        public IActionResult isInvent()
        {
            return View();
        }

    }
}
