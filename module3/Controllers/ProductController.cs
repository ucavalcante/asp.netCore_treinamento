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
        public IActionResult Save(Product product){
            if (product.Id == 0 || string.IsNullOrEmpty(product.Name)||product.Price == 0)
                ViewBag.Validacao = "Produto Invalido para cadastro";
            

            return View();
        }
    }
}