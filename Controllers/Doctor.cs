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
            string s = WebDemo.Models.FeverCheckFormData.checkTemp(temperatur);
            return View(s);
        }
    }
}
