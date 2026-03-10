using Microsoft.AspNetCore.Mvc;

namespace asp.net_crash_test.Controllers;

public class ExercicesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}