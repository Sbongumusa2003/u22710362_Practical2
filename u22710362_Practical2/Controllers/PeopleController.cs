 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u22710362_Practical2.Models;

namespace u22710362_Practical2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PersonList()
        {
            List<Person> People = new List<Person>
            {
               new Person()
               {
                   FirstName = "Sbongumusa",
                   LastName= "Mbatha",
                   Age = 27,
                   IsAlive = true,
                   myLink = "~/HTML/Individual1.html"
               },
               new Person()
               {
                   FirstName = "Phumzile",
                   LastName= "Mabuza",
                   Age = 37,
                   IsAlive = true,
                   myLink = "~/HTML/Individual2.html"
               },
               new Person()
               {
                   FirstName = "Lungile",
                   LastName= "Mbatha",
                   Age = 36,
                   IsAlive = true,
                   myLink = "~/HTML/Individual3.html"
               },
               new Person()
               {
                   FirstName = "Ayanda",
                   LastName= "Mahlangu",
                   Age = 29,
                   IsAlive = false,
                   myLink = "~/HTML/Individual4.html"
               },
               new Person()
               {
                   FirstName = "Lindo",
                   LastName= "Zulu",
                   Age = 18,
                   IsAlive = true,
                   myLink = "~/HTML/Individual5.html"
               }
            };
            return View(People);
        }
    }
}