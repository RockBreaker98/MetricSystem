using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class ConversionsController : Controller
    {
        // GET: /Conversions/Fahrenheit
[HttpGet]
        public IActionResult Fahrenheit()
        {
            ViewBag.CelsiusValue = null;
            return View(new MetricSystemModel());   // class lives in TempModel.cs
        }

        // POST: /Conversions/Fahrenheit
        [HttpPost]
        public IActionResult Fahrenheit(MetricSystemModel model)
        {
            if (ModelState.IsValid)
            {
                // use your CalculateMetricSystem() from the model
                var result = model.CalculateMetricSystem();
                ViewBag.CelsiusValue = result?.ToString("F2");
            }
            else
            {
                ViewBag.CelsiusValue = null;
            }

            // return the same model so the input keeps the typed value
            return View(model);
        }

        // GET: /Conversions/Inch
        public IActionResult Inch()
        {
            return View();
        }

        // GET: /Conversions/Pint
        public IActionResult Pint()
        {
            return View();
        }

        // GET: /Conversions/Yard
        public IActionResult Yard()
        {
            return View();
        }
    }
}