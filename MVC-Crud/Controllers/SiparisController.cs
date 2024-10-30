using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Crud.Models;
using MVC_Crud.Models.Context;

namespace MVC_Crud.Controllers
{
    public class SiparisController : Controller
    {
        private readonly MyDbContext _context;

        public SiparisController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var siparisler = _context.Siparisler.Include(s => s.Urun).Include(s => s.Musteri).ToList();
            return View(siparisler);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Siparis siparis = new Siparis();
            var siparisler = _context.Siparisler.ToList();
            return View(siparis);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Siparis siparis)
        {
            _context.Siparisler.Add(siparis);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Siparis siparis = _context.Siparisler.Find(id);

            return View(siparis);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Siparis siparis)
        {
            _context.Update(siparis);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Remove(int id)
        {
            Siparis siparis = _context.Siparisler.Where(c => c.SiparisId == id).FirstOrDefault();


            _context.Siparisler.Remove(siparis);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
