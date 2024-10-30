using Microsoft.AspNetCore.Mvc;
using MVCQueryString.Models;

namespace MVCQueryString.Controllers
{
    [Route("ogrenci")]
    public class OgrenciController : Controller
    {
        private static List<Ogrenci> ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 1, Ad = "Ahmet" },
            new Ogrenci { Id = 2, Ad = "Zeynep" }
        };

        // GET: /ogrenci/yeni
        [HttpGet("yeni")]
        public IActionResult Yeni()
        {
            return View();
        }

        // GET: /ogrenci/ekle?ad=Ali
        [HttpGet("ekle")]
        public IActionResult Ekle(string ad)
        {
            if (!string.IsNullOrWhiteSpace(ad))
            {
                var yeniOgrenci = new Ogrenci
                {
                    Id = ogrenciler.Count + 1, // Yeni ID oluşturma
                    Ad = ad
                };
                ogrenciler.Add(yeniOgrenci);
                TempData["Mesaj"] = "Öğrenci başarıyla eklendi!";
            }
            else
            {
                TempData["Mesaj"] = "Öğrenci adı boş olamaz!";
            }

            return RedirectToAction("Liste");
        }

        // GET: /ogrenci/liste
        [HttpGet("liste")]
        public IActionResult Liste()
        {
            ViewData["Ogrenciler"] = ogrenciler;
            return View();
        }

        // GET: /ogrenci/detay/1
        [HttpGet("detay/{id:int}")]
        public IActionResult Detay(int id)
        {
            var ogrenci = ogrenciler.FirstOrDefault(o => o.Id == id);
            if (ogrenci == null)
            {
                return NotFound(); // Eğer öğrenci bulunamazsa 404 döner
            }
            return View(ogrenci);
        }

        // GET: /ogrenci/sil/1
        [HttpGet("sil/{id:int}")]
        public IActionResult Sil(int id)
        {
            var ogrenci = ogrenciler.FirstOrDefault(o => o.Id == id);
            if (ogrenci != null)
            {
                ogrenciler.Remove(ogrenci);
                TempData["Mesaj"] = "Öğrenci başarıyla silindi!";
            }
            else
            {
                TempData["Mesaj"] = "Öğrenci bulunamadı!";
            }

            return RedirectToAction("Liste");
        }
    }
}
