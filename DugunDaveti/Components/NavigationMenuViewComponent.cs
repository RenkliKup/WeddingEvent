using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DugunDaveti.Models;
namespace DugunDaveti.Components
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        public IWeddingRepository repository;
        public NavigationMenuViewComponent(IWeddingRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            
            object selected_cat = RouteData?.Values["isAttend"];
            if (selected_cat != null) {
                ViewBag.SelectedCategory = selected_cat.ToString();
            } else
            {
                ViewBag.SelectedCategory =  "hepsi";
            }
            return View(repository.weddingInvents.Select(x => x.isAttend).Distinct().OrderBy(x => x));
        }
    }
}
