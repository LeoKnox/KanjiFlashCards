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
        private FlashCardContext dbContext;
        public HomeController(FlashCardContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Partial = "Body";
            ViewBag.Word = "One";
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

        [Route("populate")]
        [HttpGet]
        public IActionResult Populate()
        {
            return View("Populate");
        }

        [Route("insert")]
        [HttpPost]
        public IActionResult Insert(Kanji newKanji)
        {
            dbContext.Add(newKanji);
            dbContext.SaveChanges();
            return View("Populate");
        }
    }
}
