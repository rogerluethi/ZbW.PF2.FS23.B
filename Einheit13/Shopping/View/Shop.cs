using Einheit13.Shopping.Controller;

namespace Einheit13.Shopping.View
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();

            Controller = new ShoppingController();
            InitialProductInShop();
        }

        private ShoppingController Controller { get; }

        private void UpdateMyBasket()
        {
            LbProductsInBasket.Items.Clear();

            var procutsInBasket = Controller.GetProductsInBasket();
            foreach (var product in procutsInBasket)
            {
                LbProductsInBasket.Items.Add(product.Name);
            }
        }

        private void ClickOnBtnAdd(object sender, EventArgs e)
        {
            var checkedProducts = ClbProducts.CheckedItems;
            foreach (var item in checkedProducts)
            {
                Controller.AddProductToBasket((string)item);
            }
            UpdateMyBasket();
        }

        private void InitialProductInShop()
        {
            var procutsInShop = Controller.ProductsInShop;

            foreach (var item in procutsInShop)
            {
                ClbProducts.Items.Add(item.Name);
            }
        }
    }
}
