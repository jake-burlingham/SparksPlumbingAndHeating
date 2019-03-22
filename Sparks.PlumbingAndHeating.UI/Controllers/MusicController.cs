using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sparks.PlumbingAndHeating.UI.Models;

namespace Sparks.PlumbingAndHeating.UI.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>
            {
                new Book{ Title = "Book1", Author = "Adam Sparks" },
                new Book{ Title = "Book2", Author = "Adam Sparks" },
                new Book{ Title = "Book3", Author = "Adam Sparks" }
            };
            return View( books );
        }
    }
}