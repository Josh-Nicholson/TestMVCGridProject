using Microsoft.AspNetCore.Mvc;
using TestMVCGridProject.Models;

namespace TestMVCGridProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult DisplayMVCGrid()
        {
            return PartialView("_ExampleResultGrid", new ExampleGridModel());            
        }
    }
}