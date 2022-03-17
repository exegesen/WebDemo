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
        
        [HttpGet]
        public ActionResult Index()
        {
            PersonList.defaultList();
            return View();
        }
        [HttpGet]
        public ActionResult PeopleButton()
        {
            PersonList.defaultList();
            return PartialView("PeopleListPartial", new PersonList());
        }
        public ActionResult DetailsButton(int? id)
        {

            PersonList pl0 = new PersonList();
            pl0.PListDynamic = new List<Person>();
            
            foreach (Person person in PersonList.PList)
            {
                if (person.Id == id) { 
                    pl0.PListDynamic.Add(person);
                }

            }
            PersonList.PList = pl0.PListDynamic;

            return PartialView("PeopleListPartial", new PersonList());
        }

        public ActionResult DeleteButton(int? id)
        {
            List<Person> pl0 = new List<Person>();
            foreach (Person person in PersonList.PList)
            {
                if (person.Id != id)
                {
                    pl0.Add(person);
                }

            }
            PersonList.PList = pl0;
            return PartialView("PeopleListPartial", new PersonList());
        }

    }
}
