using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lect.Models;

namespace Lect.Controllers
{
    public class HomeController : Controller
    {

        public MovieQuotes allMoviesWeAdded = new MovieQuotes();
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Nadia = "Nadia";
            return View();
        }
        [HttpGet("click")]
        public IActionResult ShowIndex(){
            return View("Index");
        }

        [HttpPost("tempuser")]
        public IActionResult formFromIndex(string quote, string who){
            ViewBag.quoteFromForm = quote;
            ViewBag.whoFromForm = who;
            return View("Result");
        }

        [HttpGet("formwithmodel")]
        public IActionResult Quotesubmit(){
            return View();
        }

        [HttpPost("modelbind")]
        public IActionResult quoteFromModel(Quote aQuote){
            return RedirectToAction("process", aQuote);
        }

        [HttpGet("result")]
        public IActionResult process(Quote aQuote){
            allMoviesWeAdded.allQuotes.Add(aQuote);
            var list = allMoviesWeAdded.allQuotes;
            Console.WriteLine(list);
            ViewBag.moviesToDisplay = allMoviesWeAdded.allQuotes;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
