using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MissionApi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MissionApi.Models;

namespace MissionApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        

        public IActionResult Index()
        {
            List<Product> pList = new List<Product>();
            Product p = new Product();
            p.id = 1671872;
            p.Name = "Green Bottom Wear";
            p.Price = 850;
            p.imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/ser1/newchic/images/55/60/4da21dba-c700-4337-bd80-640da97dccb5.jpg";
            pList.Add(p);
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "N-95 Blue Mask",
                Price = 500,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/2E/72/1c322075-7a7a-474d-976e-6bcbc45daaec.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "90s Cap",
                Price = 350,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/C9/2E/dbb5e404-fcfe-493b-ad96-9e1adf312b80.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Hand Gloves",
                Price = 200,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/57/8A/70ed0ba8-4163-4537-9f3f-dec22c8f1ddc.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "2 in 1 shirts",
                Price = 550,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/E0/F8/8be94dee-0084-4fd6-ab64-c6b0e9598cbd.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Green T-shirt",
                Price = 599,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/EC/25/49097abd-7b50-4cda-9604-c98b8eac4664.jpeg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Protection Blue Cap",
                Price = 499,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/86/34/32269ae0-da4e-49ea-be65-b28cb6ddc484.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Grey Cap",
                Price = 299,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/64/8E/1993a967-6da8-4d71-83c6-fd40c4dba88f.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Hand Tattoo Gloves",
                Price = 1599,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/0E/1D/04f51669-0b8b-48bb-a73d-a77dde830d1c.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Hair Band",
                Price = 199,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/42/72/fb18212c-f622-4bf9-99bb-85fa4decd9e9.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Eglu Cap",
                Price = 299,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/3A/60/567b9a0a-66e3-4fdb-ad99-4155400c8714.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Winter Cap",
                Price = 250,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/4B/16/1fb6c5f1-7824-49c6-8033-a71528a99200.jpg",
            });
            IEnumerable<Product> model = pList;
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
