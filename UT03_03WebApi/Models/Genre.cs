namespace UT03_03WebApi.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Game> Games { get; set; }
    }
}
