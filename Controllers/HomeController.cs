using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FlashCard.Models;

namespace FlashCard.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Partial = "Body";
            return View();
        }

        [Route("change")]
        [HttpGet]
        public IActionResult change()
        {
            ViewBag.Partial = "Change";
            ViewBag.Kanji = "&#19968;";
            return View("Index");
        }
    }
}
