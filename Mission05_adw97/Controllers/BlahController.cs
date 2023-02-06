using Microsoft.AspNetCore.Mvc;
using Mission05_adw97.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//This controller is where we set the routes
namespace Mission05_adw97.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form (GradeFormModel model)
        {
            return View();
        }
    }
}
