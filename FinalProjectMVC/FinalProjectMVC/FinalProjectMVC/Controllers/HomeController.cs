using FinalProjectMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProjectMVC.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Extra()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Furniture()
        {
            return View();
        }

        //public IActionResult test()
        //{
        //    return View();
        //}

        public IActionResult Accessories()
        {
            return View();
        }

        //public IActionResult ItemDetails() 
        //{
        //    return View();
        //}
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult More()
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
