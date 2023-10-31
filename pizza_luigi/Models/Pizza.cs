using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace pizza_luigi.Models
{
    public class Pizza
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Nom {  get; set; }

        [Display(Name = "Prix (€)")]
        public float Prix { get; set; }

        [Display(Name = "Végétarienne")]
        public bool Vegan { get; set; }

        [Display(Name = "Ingrédients")]
        [JsonIgnore]
        public string Ingredients { get; set; }

        [NotMapped]
        [JsonPropertyName("ingredients")]
        public string[] listIngredients
        {
            get
            {
                if (Ingredients == null || Ingredients.Count() == 0) { 
                return null;
                }
                return Ingredients.Split(", ");
            }
        }
    }
}