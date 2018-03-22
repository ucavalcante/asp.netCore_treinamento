using System.ComponentModel.DataAnnotations;

namespace module3.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(10,20, ErrorMessage = "Numero de 10 a 20")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(3, ErrorMessage = "Minimo de 3 caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1,int.MaxValue, ErrorMessage = "Minimo de 1")]
        public int Price { get; set; }
    }
}