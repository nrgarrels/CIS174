using FirstResponsiveWebAppGarrels.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstResponsiveWebAppGarrels.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0; 
            return View();
        }
        [HttpPost]
        public IActionResult Index(responsive model) //Sets viewbag = to result of method and sends to form
        {
            ViewBag.FV = model.AgeThisYear(); 
            return View(model);
        }
    

}
}