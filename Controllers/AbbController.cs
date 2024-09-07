using Microsoft.AspNetCore.Mvc;

namespace Instruments.Controllers;

public class AbbController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Pressure()
    {
        return View();
    }
     public IActionResult Flow()
    {
        return View();
    }
     public IActionResult Level()
    {
        return View();
    }
     public IActionResult Temperature()
    {
        return View();
    }
}