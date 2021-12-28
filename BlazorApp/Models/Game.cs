namespace BlazorApp
{
    public class Game
    {
        public Game(string name, string genre, int year)
        {
            Name = name;
            Genre = genre;
            Year = year;
        }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
    }
}