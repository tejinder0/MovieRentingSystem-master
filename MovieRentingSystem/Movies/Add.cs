using System;
using System.Data;
using System.Windows.Forms;

namespace MovieRentingSystem.Movies
{
    public partial class Add : Form
    {
        private string MovieId;

        public Add()
        {
            InitializeComponent();
        }

        public Add(string MovieId)
        {
            this.MovieId = MovieId;
            InitializeComponent();
            DataTable table = new Database().GetMovie(MovieId);
            Rating.Text = table.Rows[0]["Rating"].ToString();
            Title.Text = table.Rows[0]["Title"].ToString();
            Year.Text = table.Rows[0]["Year"].ToString();
            Copies.Text = table.Rows[0]["Copies"].ToString();
            Plot.Text = table.Rows[0]["Plot"].ToString();
            Genre.Text = table.Rows[0]["Genre"].ToString();
            button1.Text = "Update Movie";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int YearValue, CopiesValue;

            if (Rating.Text == "" || Title.Text == "" || Year.Text == "" || Copies.Text == "" || Plot.Text == "" || Genre.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else if (!int.TryParse(Year.Text, out YearValue) || !(int.TryParse(Copies.Text, out CopiesValue)))
            {
                MessageBox.Show("Year and Copies must be a valid integer");
            }
            else
            {
                int Rental = 0;
                if ((DateTime.Now.Year - YearValue) > 5)
                {
                    Rental = 2;
                }
                else
                {
                    Rental = 5;
                }

                Movie movie = new Movie()
                {
                    Copies = CopiesValue,
                    Genre = Genre.Text,
                    Plot = Plot.Text,
                    Rating = Rating.Text,
                    Rental_Cost = Rental,
                    Title = Title.Text,
                    Year = Year.Text
                };

                Database database = new Database();
                if (button1.Text.ToLower() == "add movie")
                {
                    database.AddMovie(movie);
                    MessageBox.Show("Movie Added successfully");
                }
                else
                {
                    movie.MovieID = Convert.ToInt32(MovieId);
                    database.UpdateMovie(movie);
                    MessageBox.Show("Movie Updated successfully");
                    Dispose();
                }
            }
        }
    }
}
