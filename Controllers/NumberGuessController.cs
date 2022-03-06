using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class NumberGuess : Controller
    {
        public const string SessionKeyNumber = "_Number";
        
        public IActionResult Index()
        {
            
            HttpContext.Session.SetInt32(SessionKeyNumber, GuessGameFormData.generateNumber());
            
            return View("Index");
        }
        [HttpPost]
        public ActionResult GuessGame(GuessGameFormData form)
        {
            if (form.numberInput == HttpContext.Session.GetInt32(SessionKeyNumber)) { 
            
            }
            return View("Index");
        }
    }
}
