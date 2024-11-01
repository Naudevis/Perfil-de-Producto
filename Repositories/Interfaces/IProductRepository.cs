using ProductProfileExercise.Models;

namespace ProductProfileExercise.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Product GetProduct(string id);
    }
}
