using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webOdev.Models;

namespace webOdev.Controllers
{
    public class İletisimController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult İletisim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult İletisim(İletisim p)
        {
            c.iletisims.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index","Hayvanlar");
        }
    }
}
