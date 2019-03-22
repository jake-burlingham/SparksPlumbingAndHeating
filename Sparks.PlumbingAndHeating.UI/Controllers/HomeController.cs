using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sparks.PlumbingAndHeating.UI.Models;

namespace Sparks.PlumbingAndHeating.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Sparks Plumbing and Heating Ltd";

            return View();
        }
    }
}