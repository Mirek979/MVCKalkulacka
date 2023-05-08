using Microsoft.AspNetCore.Mvc;
using MVCKalkulacka.Models;

namespace MVCKalkulacka.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string jmeno)
        {
            Kalkulacka kalkulacka = new Kalkulacka();
            ViewBag.Jmeno = jmeno;
            return View(kalkulacka);
        }
        [HttpPost]
        public IActionResult Index(Kalkulacka kalkulacka)
        {
            if (ModelState.IsValid)
            {
                kalkulacka.VypocitejVysledek();
            }
            return View(kalkulacka);
        }
    }
}
