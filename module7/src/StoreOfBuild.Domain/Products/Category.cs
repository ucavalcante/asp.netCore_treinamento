namespace StoreOfBuild.Domain.Products
{
    public class Category
    {
        public int Id { get; private set; }
        
        public string Name { get; private set; }

        public Category (int id , string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), 'Name is required');

            Id = id;
            Name = name;
        }

    }
}