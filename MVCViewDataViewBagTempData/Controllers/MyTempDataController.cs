using Microsoft.AspNetCore.Mvc;

namespace MVCViewDataViewBagTempData.Controllers
{
    public class MyTempDataController : Controller
    {
        public IActionResult TempDataOrnegi()
        {

            TempData["Bildirim"] = "Bu mesaj TempData ile gönderildi.";

            return RedirectToAction("Goster");
        }

        public IActionResult Goster()
        {

            return View();
        }
    }
}
