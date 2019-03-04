namespace MovieRentingSystem.Movies
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Rating { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public int Rental_Cost { get; set; }
        public int Copies { get; set; }
        public string Plot { get; set; }
        public string Genre { get; set; }
    }
}
