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
            pl.PList = PersonList.defaultList();
            return PartialView("PeopleListPartial", pl);
        }
        public ActionResult DetailsButton(int? id)
        {
            PersonList pl = new PersonList()
            {
                PList = PersonList.defaultList()
            };
            PersonList pl0 = new PersonList()
            {
                PList = new List<Person>()
            };
            foreach (Person person in pl.PList)
            {
                if (person.Id == id) { 
                    pl0.PList.Add(person);
                }

            }

            return PartialView("PeopleListPartial", pl0);
        }

        public ActionResult DeleteButton(int? id)
        {



            return StatusCode(404);
        }

    }
}
