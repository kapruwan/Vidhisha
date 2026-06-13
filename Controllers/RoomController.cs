using Microsoft.AspNetCore.Mvc;
using Vidhisha.Models;

namespace Vidhisha.Controllers;

public class RoomController : Controller
{
    public IActionResult Index()
    {
        // Sample rooms to render in the view. Replace with real data source later.
        var rooms = new List<Room>
        {
            new Room
            {
                Name = "Deluxe Mountain View",
                View = "Himalayan Mountain View",
                Price = "INR 6,500",
                Image = "/Images/image1.jpeg",
                Facilities = "King bed, Ensuite bathroom, Balcony, WiFi"
            },
            new Room
            {
                Name = "Executive Suite",
                View = "Valley View",
                Price = "INR 9,000",
                Image = "/Images/image2.jpeg",
                Facilities = "King bed, Living area, Mini bar, Free breakfast"
            },
            new Room
            {
                Name = "Family Villa",
                View = "Private Garden",
                Price = "INR 12,000",
                Image = "/Images/image3.jpeg",
                Facilities = "2 Bedrooms, Kitchenette, Private lawn"
            }
        };

        return View(rooms);
    }
}
