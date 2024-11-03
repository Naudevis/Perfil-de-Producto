using ProductProfileExercise.Models;

namespace ProductProfileExercise.Components.Pages
{
    public partial class ProductList
    {
        private List<Product> product;

        protected override void OnInitialized()
        {
            product = productRepository.GetProduct();
        }
    }
}
