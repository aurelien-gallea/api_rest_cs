namespace pizza_luigi.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nom {  get; set; }
        public float Prix { get; set; }
        public bool Vegan { get; set; }
        public string Ingredients { get; set; }

    }
}
