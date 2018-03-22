using Microsoft.AspNetCore.Mvc;
using module3.Models;

namespace module3.Controllers
{
    
    public class ProductController: Controller
    {
    
        public IActionResult Save(){

            return View();
        }

        public IActionResult Save(Product product){

            return View();
        }
    }
}