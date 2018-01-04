using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Microsoft.Extensions.Options;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        WddConfig WddConfig;

        public HomeController(IOptions<WddConfig> wddConfig)
        {
            WddConfig = wddConfig.Value;
        }
        public IActionResult Index()
        {
            return View(WddConfig);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
