using Einheit13.Shopping.Model;

namespace Einheit13.Shopping.Controller
{
    internal class ShoppingController
    {

        public ShoppingController()
        {
            ShoppingBasekt = new Basket();

            ProductsInShop = new List<Product>() {
            new Product("Guess Tasche",99.50m),
            new Product { Name = "Mollerus Tasche", Price = 400.95m },
            new Product { Name = "Chancel Tasche", Price = 1500m },
            new Product { Name = "Liebkind Tasche", Price = 80m }

            };
        }

        private Basket ShoppingBasekt { get; set; }

        public List<Product> ProductsInShop { get; }

        public void AddProductToBasket(string productName)
        {
            var product = GetProductsByName(productName, ProductsInShop);
            ShoppingBasekt.Products.Add(product);
            
        }

        public List<Product> GetProductsInBasket()
        {
            return ShoppingBasekt.Products;
        }

        private Product GetProductsByName(string name, List<Product> products)
        {
            foreach (var product in products)
            {
                if (product.Name.Equals(name))
                {
                    return product;
                }
            }
            return null;
        }
    }
}
