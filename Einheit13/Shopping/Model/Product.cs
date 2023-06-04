namespace Einheit13.Shopping.Model
{
    internal class Product
    {
        public Product(string name, decimal price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
        }

        public Product()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
