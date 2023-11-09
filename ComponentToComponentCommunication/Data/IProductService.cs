namespace ComponentToComponentCommunication.Data
{
    public interface IProductService
    {
        event Action ProductEvent;
         
        List<Product> Products { get; set; }
        int ProductCount { get; set; }
        void LoadProducts();


        List<Product> MyCart { get; set; }
        int CartCount { get;set; }
        void AddToCart(Product model); 
    }
}
