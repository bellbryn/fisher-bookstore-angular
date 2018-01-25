using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Books()
        {
            return Content("These are some books");
        }
        public IActionResult Index()
        {
            return Content("this is the books index!");
        }
        public IActionResult New()
        {
            return Content("New books");
        }
    }
}