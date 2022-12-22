using Microsoft.AspNetCore.Mvc;
using yeni.Models;

namespace yeni.Controllers
{
    public class HayvanlarController : Controller
    {
        Context c=new Context();
        public IActionResult Index()
        {
            var degerler = c.Hayvanlars.ToList();
            return View(degerler);
        }
        public IActionResult İlanlar()
        {
            var degerler = c.Hayvanlars.ToList();
            return View(degerler);
        }
        public IActionResult İletisim()
        {
            return View();
        }

        [HttpGet]
        public IActionResult İlanVer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult İlanVer(Hayvanlar h)
        {
            c.Hayvanlars.Add(h);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Kayit()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
