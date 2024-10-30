using Microsoft.AspNetCore.Mvc;

namespace MVCViewDataViewBagTempData.Controllers
{
    public class MyTupleController : Controller
    {// ValueTuple tanımı
        private static (int ID, int Value1, int Value2, int Value3, int Value4) _valueTuple = (1, 2, 3, 4, 5);

        // Tuple kullanarak tanım
        private static Tuple<int, string> _tuple = new Tuple<int, string>(2, "Armut");

        public IActionResult ValueTuple()
        {
            return View(_valueTuple);
        }


        public IActionResult Tuple()
        {
            return View(_tuple);
        }
    }
}
