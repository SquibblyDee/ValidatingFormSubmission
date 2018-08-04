using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidatingFormSubmission.Models;

namespace ValidatingFormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(FormData data)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Register");
            }
            return View("Index");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
