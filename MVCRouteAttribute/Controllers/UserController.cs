using Microsoft.AspNetCore.Mvc;
using MVCRouteAtribute.Models;

namespace MVCRouteAtribute.Controllers
{
    [Route("kullanici")]
    public class UserController : Controller
    {
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Baran", Email = "baran@example.com" },
            new User { Id = 2, Name = "Ayşe", Email = "ayse@example.com" }
        };

        // GET: /kullanici/ekle
        [HttpGet("ekle")]
        public IActionResult Ekle()
        {
            return View();
        }

        // POST: /kullanici/ekle
        [HttpPost("ekle")]
        public IActionResult Ekle(User yeniKullanici)
        {
            yeniKullanici.Id = users.Max(u => u.Id) + 1;
            users.Add(yeniKullanici);

            TempData["Mesaj"] = "Kullanıcı başarıyla eklendi!";
            return RedirectToAction("Liste");
        }

        // GET: /kullanici/liste
        [HttpGet("liste")]
        public IActionResult Liste()
        {
            ViewData["Users"] = users;
            return View();
        }

        // GET: /kullanici/sil/{id}
        [HttpGet("sil/{id:int}")]
        public IActionResult Sil(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                users.Remove(user);
                TempData["Mesaj"] = "Kullanıcı başarıyla silindi!";
            }
            else
            {
                TempData["Mesaj"] = "Kullanıcı bulunamadı!";
            }

            return RedirectToAction("Liste");
        }

        // GET: /kullanici/detay/{id}
        [HttpGet("detay/{id:int}")]
        public IActionResult Detay(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                TempData["Mesaj"] = "Kullanıcı bulunamadı!";
                return RedirectToAction("Liste");
            }

            return View(user);
        }
    }
}
