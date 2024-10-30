using Microsoft.AspNetCore.Mvc;
using MVCListeCRUD.Models;
using System.Diagnostics.Metrics;

namespace MVCListeCRUD.Controllers
{
    public class PersonelController : Controller
    {
        private static List<Personel> personelListesi = new List<Personel>();
        private static int id = 1;
        public IActionResult Index()
        {
            return View(personelListesi);
        }
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Personel personel)
        {
            if (ModelState.IsValid)
            {
                personel.Id = id++;
                personelListesi.Add(personel);
                return RedirectToAction("Index");
            }
            return View(personel);
        }
        public IActionResult Guncelle(int id)
        {
            var personel = personelListesi.FirstOrDefault(p => p.Id == id);
            if (personel == null)
            {
                return NotFound();
            }
            return View(personel);
        }
        [HttpPost]
        public IActionResult Guncelle(Personel personel)
        {
            if (ModelState.IsValid)
            {
                var mevcutPersonel = personelListesi.FirstOrDefault(p => p.Id == personel.Id);
                if (mevcutPersonel == null)
                {
                    return NotFound();
                }
                mevcutPersonel.Ad = personel.Ad;
                mevcutPersonel.Soyad = personel.Soyad;
                return RedirectToAction("Index");
            }
            return View(personel);
        }
        public IActionResult Sil(int id)
        {
            var personel = personelListesi.FirstOrDefault(p => p.Id == id);
            if (personel != null)
            {
                personelListesi.Remove(personel);
            }
            return RedirectToAction("Index");
        }
    }
}
