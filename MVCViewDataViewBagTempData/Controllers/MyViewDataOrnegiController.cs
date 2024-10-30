using Microsoft.AspNetCore.Mvc;

namespace MVCViewDataViewBagTempData.Controllers
{
    public class MyViewDataOrnegiController : Controller
    {
        public IActionResult ViewDataOrnegi()
        {

            ViewData["Mesaj"] = "Bu mesaj ViewData ile gönderildi.";
            ViewData["Yil"] = 2024;

            return View();
        }
    }
}
