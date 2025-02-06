namespace MVC_ITI.Models
{
    public class ProductBL
    {
        List<Product> products;
        public ProductBL()
        {
            products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "Pineapple", Price = 50,Description="Fruit",Image="2.jpg" }) ;
            products.Add(new Product() { Id = 2, Name = "apple", Price = 25, Description = "Fruit", Image = "1.jpg" });
            products.Add(new Product() { Id = 3, Name = "orange", Price = 75, Description = "Fruit", Image = "3.jpg" });
        }

        public List<Product>GetALL()
        {
            return products;
        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
