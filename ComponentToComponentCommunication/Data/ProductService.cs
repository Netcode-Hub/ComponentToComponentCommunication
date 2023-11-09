
namespace ComponentToComponentCommunication.Data
{
    public class ProductService : IProductService
    {
        public event Action? ProductEvent;


        public List<Product> Products { get; set; } = new();
        public int ProductCount { get; set; }
        public void LoadProducts()
        {
            Products = new(){
            new Product() { Name = "Television " },
            new Product() { Name = "Mobile " },
            new Product() { Name = "Desktop " },
            new Product() { Name = "Laptop " },
            new Product() { Name = "Refrigerator " },
            new Product() { Name = "Computer " },
            new Product() { Name = "Keyboard " },
            new Product() { Name = "Mouse " },
            new Product() { Name = "Monitor " },
            new Product() { Name = "Microphone " },
            new Product() { Name = "Speaker " }
        };
            ProductCount = Products.Count;
            ProductEvent?.Invoke();
        }


        public List<Product> MyCart { get; set; } = new();
        public int CartCount { get; set; }
        public void AddToCart(Product model)
        {
            MyCart.Add(model);
            CartCount = MyCart.Count;
            ProductEvent?.Invoke();
        }
    }
}
