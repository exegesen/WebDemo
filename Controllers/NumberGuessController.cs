using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class NumberGuess : Controller
    {
        public const string SessionKeyNumber = "_Number";
        public const string SessionWrongRightGuess = "_GuessDisplay";
        public const string SessionHint = "_HintDisplay";

        [HttpGet]
        public IActionResult Index()
        {
            
            HttpContext.Session.SetInt32(SessionKeyNumber, GuessGameFormData.generateNumber());
            HttpContext.Session.SetString(SessionWrongRightGuess, "No guess made yet!");


            return View("Index");
        }
        [HttpPost]
        public ActionResult Index(GuessGameFormData form)
        {

            if (form.numberInput > HttpContext.Session.GetInt32(SessionKeyNumber))
            {

                HttpContext.Session.SetString(SessionWrongRightGuess, "Too high!");
                return View("Index");
            }
            else if (form.numberInput < HttpContext.Session.GetInt32(SessionKeyNumber))
            {
                HttpContext.Session.SetString(SessionWrongRightGuess, "Too low!");
                return View("Index");

            }
            if (form.numberInput == HttpContext.Session.GetInt32(SessionKeyNumber))
            {
                HttpContext.Session.SetString(SessionWrongRightGuess, "Correct guess!");
            }
            else {
                HttpContext.Session.SetString(SessionWrongRightGuess, "Wrong guess!");

            }

            return View("Index");
        }
    }
}
