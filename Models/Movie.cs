namespace Alkemy_Challenge_Ingreso.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Rating { get; set; }
        //relacion con generos
        public Genre Genre { get; set; }
        //relacion con personajes
        public ICollection<Character> Characters { get; set; } = new List<Character>();  


    }
}
