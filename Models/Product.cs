using System.ComponentModel.DataAnnotations;

namespace ProductProfileExercise.Models
{
    public class Product
    {
        [Required(ErrorMessage ="El Id es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es requerido")]
        public string Name { get; set; }

        [Range(0,100000,ErrorMessage ="El precio debe de ser entre 0 y 100000")]
        public double Price { get; set; }

        [StringLength(200,ErrorMessage ="La descripción no debe de ser mayor a 200 caracteres") ]
        public string Description { get; set; }
    }
}
