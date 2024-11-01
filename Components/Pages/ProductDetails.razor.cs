using Microsoft.AspNetCore.Components;
using ProductProfileExercise.Models;

namespace ProductProfileExercise.Components.Pages
{
    public partial class ProductDetails
    {
        [Parameter]
        public Product product { get; set; }
    }
}
