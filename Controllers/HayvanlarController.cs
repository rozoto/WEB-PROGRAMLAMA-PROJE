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
            var deger = c.Hayvanlars.ToList();
            return View(deger);
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
        public IActionResult İlanVer(İlanOlustur i)
        {
            Hayvanlar f = new Hayvanlar();
            if (i.Hayvanİmage != null)
            {
                var extension = Path.GetExtension(i.Hayvanİmage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "~/wwwroot/css/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                i.Hayvanİmage.CopyTo(stream);
                f.Hayvanİmage = newimagename;
            }
            f.HayvanName = i.HayvanName;
            f.HayvanCins = i.HayvanCins;
            f.HayvanCinsiyet = i.HayvanCinsiyet;
            f.HayvanIrk = i.HayvanIrk;
            f.HayvanAgirlik = i.HayvanAgirlik;
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
