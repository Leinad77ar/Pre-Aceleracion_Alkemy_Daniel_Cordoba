namespace Alkemy_Challenge_Ingreso.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public string History { get; set; }
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
