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
    }
}
