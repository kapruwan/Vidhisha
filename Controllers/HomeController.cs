using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Vidhisha.Models;

namespace Vidhisha.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Rooms()
    {
        var rooms = new List<Room>
        {
            new Room { Name = "Deluxe Room", View = "Mountain View", Price = "Coming Soon", Image = "/images/deluxe.jpg", Facilities = "32\" LED TV, Air Conditioning, Premium Bedding, Modern Bathroom" },
            new Room { Name = "Premium Mountain View Room", View = "Panoramic Mountain View", Price = "Coming Soon", Image = "/images/premium.jpg", Facilities = "Private Balcony, Mountain View, Hot Water, WiFi, Coffee Maker" },
            new Room { Name = "Family Suite", View = "Garden & Mountain View", Price = "Coming Soon", Image = "/images/suite.jpg", Facilities = "Multiple Bedrooms, Living Area, Kitchenette, Spacious Balcony" }
        };
        return View(rooms);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
