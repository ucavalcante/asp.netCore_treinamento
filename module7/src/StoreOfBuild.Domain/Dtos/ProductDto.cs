namespace StoreOfBuild.Domain.Dtos
{
    public class ProductDto
    {
        public int Id  { get;  set; }
        public string Name { get;  set; }
        public int CategoryID { get;  set; }
        public decimal Price { get;  set; }
        public int StockQuantity { get;  set; } 
    }
}