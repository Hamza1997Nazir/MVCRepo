using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        //GET : /Helloworld/
        public IActionResult Index()
        {
            return View();
        }

        //GET /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Mucho Gusto " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
            //return HtmlEncoder.Default.Encode($"Hello {name},ID {ID}");

        }

        
    }
}
