using Microsoft.AspNetCore.Mvc;

namespace Instruments.Controllers;

public class InstrumentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}