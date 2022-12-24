using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using odevvv.Models;

namespace odevvv.Controllers
{
    public class HayvanlarController : Controller
    {
        Context c = new Context();
        [AllowAnonymous]

        public IActionResult Index()
        {
            var degerler = c.Hayvanlars.ToList();
            return View(degerler);
        }
        [AllowAnonymous]

        public IActionResult İlanlar()
        {
            var degerler = c.Hayvanlars.ToList();
            return View(degerler);
        }
        [AllowAnonymous]

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
        public IActionResult İlanVer(İlanOlustur h)
        {
            Hayvanlar f = new Hayvanlar();
            if (h.Hayvanİmage != null)
            {
                var extension = Path.GetExtension(h.Hayvanİmage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "~/wwwroot/css/", newimagename);
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
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public IActionResult HayvanBul()
        {
            return View();
        }
    }
}
