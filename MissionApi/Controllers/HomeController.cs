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
            p.Name = "Pantalon bouffant ample en 100 % coton";
            p.Price = 29.39;
            p.imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/ser1/newchic/images/55/60/4da21dba-c700-4337-bd80-640da97dccb5.jpg";
            pList.Add(p);
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Pantalon bouffant ample en 100 % coton",
                Price = 29.39,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/D4/F6/cb270942-4471-4ac1-b19a-f6ed6a6cf1ae.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Pantalon bouffant ample en 100 % coton",
                Price = 29.39,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/E2/6B/c3b5dc3b-5d9f-4e2f-8d36-d2cecb4c3acf.jpeg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Pantalon bouffant ample en 100 % coton",
                Price = 29.39,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/06/88/0fc06d4d-95bf-4f21-9e4f-3d6b803e49fb.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Pantalon bouffant ample en 100 % coton",
                Price = 29.39,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/E0/F8/8be94dee-0084-4fd6-ab64-c6b0e9598cbd.jpg",
            });
            pList.Add(new Product()
            {
                id = 1671874,
                Name = "Pantalon bouffant ample en 100 % coton",
                Price = 29.39,
                imageUrl = "https://imgaz1.chiccdn.com/thumb/view/oaupload/newchic/images/EC/25/49097abd-7b50-4cda-9604-c98b8eac4664.jpeg",
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
