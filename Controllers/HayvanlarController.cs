using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webOdev.Models;

namespace webOdev.Controllers
{
    
    public class HayvanlarController : Controller
    {
        Context c = new Context();
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
       
        [HttpGet]
        [Authorize]
        public IActionResult İlanVer()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult İlanVer(İlanOlustur h)
        {
            Hayvanlar f = new Hayvanlar();
            if (h.Hayvanİmage != null)
            {
                var extension = Path.GetExtension(h.Hayvanİmage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/css/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                h.Hayvanİmage.CopyTo(stream);
                f.Hayvanİmage = newimagename;
            }
            f.HayvanName = h.HayvanName;
            f.HayvanCins = h.HayvanCins;
            f.HayvanCinsiyet = h.HayvanCinsiyet;
            f.HayvanIrk = h.HayvanIrk;
            f.HayvanAgirlik = h.HayvanAgirlik;
            c.Hayvanlars.Add(f);
            c.SaveChanges();
            return RedirectToAction("İlanlar");
        }
        [Authorize]
        public IActionResult Sahiplen(int id)
        {
            var hayvan = c.Hayvanlars.Find(id);
            c.Hayvanlars.Remove(hayvan);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
