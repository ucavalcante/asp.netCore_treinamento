using StoreOfBuild.Domain.Dtos;

namespace StoreOfBuild.Domain.Products
{
    public class ProductStorer
    {

        private readonly IRepository<Product> _productRepository ;
        private readonly IRepository<Category> _categoryRepository ;
        public ProductStorer(IRepository<Product> productRepository, IRepository<Category> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }


        public void Store(ProductDto dto)
        {

        }
    }
}