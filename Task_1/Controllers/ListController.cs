using Microsoft.AspNetCore.Mvc;

namespace Task_1.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
