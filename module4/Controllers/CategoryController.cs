using Microsoft.AspNetCore.Mvc;

namespace module4.Controllers
{
    public class CategoryController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}