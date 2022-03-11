using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using WebDemo.Models;
namespace WebDemo.Controllers
{
    public class AjaxController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Index");
        }

        
        public ActionResult PeopleButton()
        {
            return PartialView("Index");
        }

        
        public ActionResult DetailsButton()
        {
            return PartialView("Index");
        }
    }
}
