using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebDemo.Models;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;

namespace WebDemo.Controllers
{
    public class AjaxController : Controller
    {
        public PersonList pl = new PersonList()
        {
            PList = new List<Person>()
        };
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult PeopleButton()
        {

            

            Person p0 = new Person()
            {
                Name = "Dillip",
                Id = Person.Counter(),
                City = "Georgestown",
            };
            Person p1 = new Person()
            {
                Name = "Anton",
                Id = Person.Counter(),
                City = "Malmö",
            };
            Person p2 = new Person()
            {
                Name = "Peter",
                Id = Person.Counter(),
                City = "Foggy Bottom",
            };
            Person p3 = new Person()
            {
                Name = "Lisa",
                Id = Person.Counter(),
                City = "Mexico City",
            };
            pl.PList.Add(p0);
            pl.PList.Add(p1);
            pl.PList.Add(p2);
            pl.PList.Add(p3);
            return PartialView("PeopleListPartial", pl);
        }
        public JsonResult DetailsButton()
        {
            return Json("My String", JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteButton()
        {
            return Json("My String", JsonRequestBehavior.AllowGet);
        }

    }
}
