using System.ComponentModel.DataAnnotations;
namespace module3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}