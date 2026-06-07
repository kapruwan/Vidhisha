using Microsoft.AspNetCore.Mvc;

namespace Vidhisha.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
