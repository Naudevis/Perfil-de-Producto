using Microsoft.AspNetCore.Components;
using ProductProfileExercise.Models;

namespace ProductProfileExercise.Components.Pages
{
    public partial class ProductProfile
    {
        [Parameter]
        public string id { get; set; }
        private Product product;

        protected override void OnInitialized()
        {

            product = productRepository.GetProductById(id);
            Console.WriteLine(product != null ? "Producto obtenido correctamente" : "No se obtuvo ningun producto");


        }
    }
}
