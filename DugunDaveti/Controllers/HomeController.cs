using DugunDaveti.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DugunDaveti.Models.ViewModels;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace DugunDaveti.Controllers
{
    public class HomeController : Controller
    {
        Repository new1 = new Repository();
        IWeddingRepository db;
        public int pageSize = 4;
       
        
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
        public IActionResult isInvent(WeddingInvent invent)
        {
            if(ModelState.IsValid)
            {
                db.saveInvents(invent);
                return View("isInvent", invent);
            }
                return View("isInvent");
            //return View("isInvent",invent);




        }

        public IActionResult Privacy(string isAttend,int participantPage = 1)
        {
            
            return View("Privacy",new ParticipantListViewModel{weddingInvents=db.weddingInvents.OrderBy(x=>x.TelNo).
                Where(x=>isAttend==null   || x.isAttend==Boolean.Parse(isAttend)).
                
                Skip((participantPage - 1) * pageSize).Take(pageSize).AsEnumerable(),
                PageingInfo = new PageingInfo {
                    CurrentPage=participantPage,
                    participantperPage=pageSize,
                    totalParticipant= isAttend == null ?
                    db.weddingInvents.Count() :
                    db.weddingInvents.Where(e => 
                        e.isAttend == bool.Parse(isAttend)).Count()
                },
                 currentCategory = isAttend

            });
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
