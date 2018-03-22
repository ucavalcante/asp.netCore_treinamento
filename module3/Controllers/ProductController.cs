using Microsoft.AspNetCore.Mvc;

namespace module3.Controllers
{
    [Route("api/product")]
    public class ProductController
    {
        [HttpGet("{id:int}")]
        public int Get(int id){

            return id;
        }
    }
}