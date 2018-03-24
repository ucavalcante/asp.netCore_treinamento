using System.Linq;
using Microsoft.AspNetCore.Mvc;
using module4.Data;
using module4.Domain;

namespace module4.Controllers
{
    public class CategoryController: Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }
        [HttpPost]
        public IActionResult Register(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return  RedirectToAction("Index");
        }
    }
}