using CqrsMediatR.Models;

namespace CqrsMediatR.Data
{
    public class FakeDataStore
    {
        private static List<Product> _products;

        public FakeDataStore()
        {
            _products = new List<Product>()
            {
                new Product{Id=1, Name="Product 1"},
                new Product{Id=2, Name="Product 2"},
                new Product{Id=3, Name="Product 3"},
                new Product{Id=4, Name="Product 4"}
          };
        }

        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllProducts() => await Task.FromResult(_products);

        public async Task<Product> GetAllProductById(int id) => await Task.FromResult(_products.Single(a => a.Id == id));





    }
}