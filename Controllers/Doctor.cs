using Microsoft.AspNetCore.Mvc;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class Doctor : Controller
    {
        public IActionResult FeverCheck()
        {
            return View("FeverCheck");

        }
        [HttpPost]
        public ActionResult FeverCheck(FeverCheckFormData form)
        {
            float temperatur = form.TemperaturData;
            if (temperatur < 35.0)
            {
                ViewBag.FeberInteFeber = "För låg kroppstemperatur";
            }
            else if (temperatur > 38.0)
            {
                ViewBag.FeberInteFeber = "Du har feber";
            }
            else {
                ViewBag.FeberInteFeber = "Du har normal kroppstemperatur";

            }
                return View("FeverCheck");
        }
    }
}
