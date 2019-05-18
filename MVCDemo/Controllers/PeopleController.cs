using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {

        List<PersonModel> people = new List<PersonModel>();
        // GET: People
        public ActionResult Index()
        {
           

            people.Add(new PersonModel { FirstName = "Tim", LastName = " Corey", Age = 23, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Jack", LastName = " Martine", Age = 43, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Salim", LastName = " Jeff", Age = 53, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Mike", LastName = " Sunny", Age = 63, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Sarah", LastName = " harry", Age = 74, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Tony", LastName = " Tom", Age = 18, IsAlive = true });

            return View(people);
        }

        public ActionResult Edit(PersonModel people)
        {
            var firstName = people.FirstName;
            var lastName = people.LastName;
            var age = people.Age;
            var isAlive = people.IsAlive;

            return View(people);
        }

        public ActionResult Details(PersonModel people)
        {
            var firstName = people.FirstName;
            var lastName = people.LastName;
            var age = people.Age;
            var isAlive = people.IsAlive;

            return View(people);
        }

        public ActionResult Delete(PersonModel people)
        {
            var firstName = people.FirstName;
            var lastName = people.LastName;
            var age = people.Age;
            var isAlive = people.IsAlive;


            return View(people);
        }


    }
}