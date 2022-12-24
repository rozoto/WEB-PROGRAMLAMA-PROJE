using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using odevvv.Models;

namespace odevvv.Controllers
{
    public class KayitController : Controller
    {
        Context c = new Context();
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Kayit()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Kayit(Admin h)
        {
            

            c.Admins.Add(h);
            c.SaveChanges();
            return RedirectToAction("Index", "Hayvanlar");
        }
    }
}
