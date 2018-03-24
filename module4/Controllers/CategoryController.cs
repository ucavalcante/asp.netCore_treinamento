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
        public IActionResult Index(int Id)
        {
            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;

            var categorySelected = _context.Categories.FirstOrDefault(c => c.Id == Id);
            return View(categorySelected);
        }
        [HttpPost]
        public IActionResult Register(Category category)
        {
            if (category.Id ==0)
            {
                _context.Categories.Add(category);    
            }
            else
            {
                var categorySaved = _context.Categories.FirstOrDefault(c => c.Id == category.Id);
                categorySaved.Name = category.Name;
                _context.Categories.Update(categorySaved);
            }
            
            _context.SaveChanges();
            return  RedirectToAction("Index");
        }
    }
}