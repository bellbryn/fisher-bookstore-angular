using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return Content("This is the about section!");
        }
        public IActionResult Index()
        {
            return Content("this is the index!");
        }
        public IActionResult Location()
        {
            return Content("My location.");
        }
    }
}