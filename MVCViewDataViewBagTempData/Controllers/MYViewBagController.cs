using Microsoft.AspNetCore.Mvc;

namespace MVCViewDataViewBagTempData.Controllers
{
    public class MYViewBagController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Mesaj = "Bu mesaj ViewBag ile gönderildi.";


            return View();
        }
    }
}
