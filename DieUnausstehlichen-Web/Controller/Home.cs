using System.Diagnostics;
using DieUnausstehlichen_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DieUnausstehlichen_Web.Controller
{
    public class Home : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}