using Microsoft.AspNetCore.Mvc;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class NumberGuessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GuessGame(GuessGameFormData form)
        {
            
            
            return View("");
        }
    }
}
