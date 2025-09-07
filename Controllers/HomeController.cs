using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.CelsiusValue = null;                 
        return View(new MetricSystemModel());       
    }

    
    [HttpPost]
    public IActionResult Index(MetricSystemModel model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.CelsiusValue = model.CalculateMetricSystem(); 
        }
        else
        {
            ViewBag.CelsiusValue = null;            
        }

        return View(model);                        
    }

    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}