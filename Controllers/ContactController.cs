using Microsoft.AspNetCore.Mvc;
using Vidhisha.Models;

namespace Vidhisha.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(Contact contact)
    {
        if (ModelState.IsValid)
        {
            // Store contact inquiry (can be extended with database later)
            TempData["Message"] = "Thank you for your inquiry! We'll get back to you soon.";
            return RedirectToAction("Index");
        }

        return View("Index", contact);
    }
}
