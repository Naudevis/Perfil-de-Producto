using ProductProfileExercise.Models;
using ProductProfileExercise.Repositories.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace ProductProfileExercise.Repositories
{
    public class ProductRepository : IProductRepository
    {


        private readonly List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Azúcar", Price = 1000, Description = "1kg" },
            new Product { Id = 2, Name = "Sal", Price = 500, Description = "500g" },
            new Product { Id = 3, Name = "Arroz", Price = 2000, Description = "2kg" }
        };

        public Product GetProduct(string id)
        {
            int newId = Int32.Parse(id);
            var product = products.Find(p => p.Id == newId);
      
            return product;
        }
        
    }
    
}
