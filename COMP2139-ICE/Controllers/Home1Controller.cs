using Microsoft.AspNetCore.Mvc;

namespace COMP2139_ICE.Controllers;
    public class Home1Controller : Controller
    {
        // GET: Home1Controller
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult index()
        {
            return View();
        }
        
        
    }