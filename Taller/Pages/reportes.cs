using Microsoft.AspNetCore.Mvc;

namespace Taller.Pages;

public class reportes : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}