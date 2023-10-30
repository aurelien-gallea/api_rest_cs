using System.ComponentModel.DataAnnotations;

namespace pizza_luigi.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nom {  get; set; }

        [Display(Name = "Prix (€)")]
        public float Prix { get; set; }

        [Display(Name = "Végétarienne")]
        public bool Vegan { get; set; }
        [Display(Name = "Ingrédients")]
        public string Ingredients { get; set; }
    }
}