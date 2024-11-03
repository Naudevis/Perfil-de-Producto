using ProductProfileExercise.Models;

namespace ProductProfileExercise.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(string id);
        List<Product> GetProduct();

    }
}
