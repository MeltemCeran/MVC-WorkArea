using Microsoft.AspNetCore.Mvc;
using MVC_Crud.Models;
using MVC_Crud.Models.Context;

namespace MVC_Crud.Controllers
{
    public class MusteriController : Controller
    {
        private readonly MyDbContext _context;

        public MusteriController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var musteriler = _context.Musteriler.ToList();
            return View(musteriler);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Musteri musteri = new Musteri();
            var musteriler = _context.Musteriler.ToList();
            return View(musteri);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Musteri musteri)
        {
            _context.Musteriler.Add(musteri);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Musteri musteri = _context.Musteriler.Find(id);

            return View(musteri);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Musteri musteri)
        {
            _context.Update(musteri);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Remove(int id)
        {
            Musteri musteri = _context.Musteriler.Where(c => c.MusteriId == id).FirstOrDefault();


            _context.Musteriler.Remove(musteri);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
