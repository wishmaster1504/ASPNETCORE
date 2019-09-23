using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        //[Route("")]
        //[Route("/")]
        //[Route("Home")]
        //[Route("[action]")]
        public ViewResult Index() // IActionResult
        {
            return View();
            //return "Index() Action Method of HomeController";
        }

        //[Route("[action]")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[Route("[action]")]
        public ViewResult Details()
        {
            //return "Details() Action Method of HomeController, ID Value = " + id;
            return View();
        }


        //[Route("[action]")]
        public IActionResult About()
        {
            //return "About() Action Method of HomeController";
            return View();
        }

    }
}
