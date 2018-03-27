using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreOfBuild.Domain.Dtos;
using StoreOfBuild.web.Models;

namespace StoreOfBuild.web.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateOrEdit()
        {
            var x = HttpContext.Response.Body;
            var y = x.ToString();
            return View();
        }
        [HttpPost]
        public IActionResult CreateOrEdit(CategoryDto dto)
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
