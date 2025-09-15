using System.Diagnostics;
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
            return View();
        }

        // POST: /Conversions/Fahrenheit
        [HttpPost]
        public IActionResult Fahrenheit(double? fahrenheit)
        {
            if (fahrenheit == null)
            {
                ViewBag.Error = "Please enter a Fahrenheit value.";
                return View();
            }

            double celsius = (fahrenheit.Value - 32) * 5 / 9;
            ViewBag.Result = $"{celsius:F2}";
            ViewBag.Fahrenheit = fahrenheit;
            return View();
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