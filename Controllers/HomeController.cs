using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignUpGenius.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

//This controls the program
namespace SignUpGenius.Controllers
{
    public class HomeController : Controller
    {
        //The context file
        private SignUpListContext context { get; set; }
        public HomeController(SignUpListContext con)
        {
            context = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUpPage()
        {
            return View(context.signUpTimes);
        }

        //The get method to get the date and time info
        [HttpGet]

        public IActionResult SignUpForm(string date, string time)
        {
            ViewBag.date = date;
            ViewBag.time = time;
            return View();
        }

        //the post method that adds and saves changes with sign up forms
        [HttpPost]
        public IActionResult SignUpForm(SignUpItem s)
        {

            if (ModelState.IsValid)
            {
                context.signUps.Add(s);
                context.SaveChanges();
            }
            return View("Index");
        }
        public IActionResult ViewAppointments()
        {
            return View(context.signUps);
        }
    }
}
