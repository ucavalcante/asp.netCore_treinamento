using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreOfBuild.Domain.Products;
using StoreOfBuild.web.Models;
using StoreOfBuild.web.ViewsModels;

namespace StoreOfBuild.web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryStorer _categoryStorer;

        public CategoryController(CategoryStorer categoryStorer)
        {
            _categoryStorer = categoryStorer;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateOrEdit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateOrEdit(CategoryViewModel viewModel)
        {
            _categoryStorer.Store(viewModel.Id,viewModel.Name);
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
