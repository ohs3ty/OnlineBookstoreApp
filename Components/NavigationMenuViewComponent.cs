using Microsoft.AspNetCore.Mvc;
using OnlineBookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreApp.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private iBookRepository repository;

        public NavigationMenuViewComponent (iBookRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books 
                       .Select(x => x.Category)
                       .Distinct()
                       .OrderBy(x => x));
           
        }
    }
}
