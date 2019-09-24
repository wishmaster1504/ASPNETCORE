using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstWebApp.Models;
using MyFirstWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class StudentController : Controller
    {
        //[Route("Student/Details")]
        public ViewResult Details()
        {
            ViewBag.Title = "Student Details Page";
            ViewBag.Header = "Student Details";
            //Student Basic Details
            Student student = new Student()
            {
                StudentId = 101,
                Name = "Dillip",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            //Student Address
            Address address = new Address()
            {
                StudentId = 101,
                City = "Mumbai",
                State = "Maharashtra",
                Country = "India",
                Pin = "400097"
            };
            //Creating the View model
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details",
            };
            //Pass the studentDetailsViewModel to the view
            return View(studentDetailsViewModel);
        }

        public string Index(string id)
        {
            return string.Format(format: "Index(" + id + ") Action Method of StudentController");
        }
    }
}
