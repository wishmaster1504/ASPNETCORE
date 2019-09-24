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

            List<Student> listStudents = new List<Student>()
            {
               new Student() { StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
               new Student() { StudentId = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
               new Student() { StudentId = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
            };

             
            return View(listStudents);
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
        public ViewResult Details(int Id)
        {
            //return "Details() Action Method of HomeController, ID Value = " + id;
            var studentDetails = new Student() { StudentId = Id, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" };
            return View(studentDetails);
        }


        //[Route("[action]")]
        public IActionResult About()
        {
            //return "About() Action Method of HomeController";
            return View();
        }

    }
}
