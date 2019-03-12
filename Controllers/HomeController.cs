using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FlashCard.Models;
using Microsoft.AspNetCore.Http;

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
            return View();
        }

        [Route("tonew")]
        [HttpGet]
        public IActionResult tonew()
        {
            List<Kanji> KanjiList = dbContext.Kanjis.ToList();
            Random rnd = new Random();
            int x = rnd.Next(0, KanjiList.Count);
            HttpContext.Session.SetString("Kanji", KanjiList[x].DisplayKanji);
            HttpContext.Session.SetString("Word", KanjiList[x].DisplayWord);
            HttpContext.Session.SetString("Kana", KanjiList[x].Kana);
            ViewBag.Partial = "Kanji";
            ViewBag.Kanji = HttpContext.Session.GetString("Kana");
            return View("Index");
        }

        [Route("word")]
        [HttpGet]
        public IActionResult word()
        {
            ViewBag.Partial = "Body";
            ViewBag.Word = HttpContext.Session.GetString("Word");
            return View("Index");
        }

        [Route("change")]
        [HttpGet]
        public IActionResult change()
        {
            ViewBag.Partial = "Kanji";
            ViewBag.Kanji = HttpContext.Session.GetString("Kanji");
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
