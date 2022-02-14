namespace Alkemy_Challenge_Ingreso.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
            }
}
