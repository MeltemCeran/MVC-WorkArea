using Microsoft.AspNetCore.Mvc;
using MVCListeCRUD.Models;

public class UrunController : Controller
{
    private static List<Urun> urunler = new List<Urun>();

    // Ürün listesini gösteren action
    public IActionResult Liste()
    {
        return View(urunler); // Listeyi view'e gönderiyoruz.
    }

    // Ürün ekleme formunu gösteren action
    [HttpGet]
    public IActionResult Ekle()
    {
        return View(); // Ürün ekleme sayfasını açıyoruz.
    }

    // Ürün ekleme işlemi
    [HttpPost]
    public IActionResult Ekle(Urun urun)
    {
        urun.Id = urunler.Count + 1; // Yeni ürün için ID ayarlama
        urunler.Add(urun); // Ürünü listeye ekliyoruz.
        return RedirectToAction("Liste"); // Liste sayfasına yönlendiriyoruz.
    }

    // Ürün listesini tablo formatında gösteren action
    public IActionResult Tablo()
    {
        return View(urunler); // Tabloyu view'e gönderiyoruz.
    }
}
