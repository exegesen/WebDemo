﻿using Microsoft.AspNetCore.Mvc;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck()
        {
            return View("FeverCheck");

        }
        [HttpPost]
        public ActionResult FeverCheck(FeverCheckFormData form)
        {
            float temperatur = form.TemperaturData;
            ViewBag.TemperaturData = WebDemo.Models.FeverCheckFormData.checkTemp(temperatur);
            
            return View("FeverCheck");
        }
    }
}
