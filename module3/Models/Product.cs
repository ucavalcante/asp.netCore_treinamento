using System.ComponentModel.DataAnnotations;

namespace module3.Models
{
    public class Product
    {
        [Required]
        [Range(10,20)]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public int Price { get; set; }
    }
}