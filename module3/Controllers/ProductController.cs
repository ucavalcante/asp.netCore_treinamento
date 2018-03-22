using Microsoft.AspNetCore.Mvc;
using module3.Models;

namespace module3.Controllers
{
    
    public class ProductController: Controller
    {
        [HttpGet]
        public IActionResult Save(){

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Product product){
            if (!ModelState.IsValid)
                ViewBag.Validacao = "Produto Invalido para cadastro";
            

            return View();
        }
    }
}