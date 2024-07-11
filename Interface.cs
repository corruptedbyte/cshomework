using System;
using System.Collections;

namespace ConsoleApp6
{
    internal class Interface
    {
        class Cinema : IEnumerable<Movie>
        {
            private List<Movie> movies = new List<Movie>();

            public void AddMovie(Movie movie)
            {
                movies.Add(movie);
            }

            public void SortMovies(IComparer<Movie> comparer)
            {
                movies.Sort(comparer);
            }

            public IEnumerator<Movie> GetEnumerator()
            {
                return movies.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        class Director : ICloneable
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Description { get; set; }

            public Director()
            {
                FirstName = "No Firstname";
                LastName = "No LastName";
                Description = "No description";
            }

            public Director(string First, string Last, string desk)
            {
                FirstName = First;
                LastName = Last;
                Description = desk;
            }

            public override string ToString()
            {
                return $"First name: {FirstName}, Last name: {LastName}, Description: {Description}";
            }

            public object Clone()
            {
                return new Director(FirstName, LastName, Description);
            }
        }

        enum Genre { Comedy, Horror, Adventure, Drama, Fantasy }

        class Movie : ICloneable, IComparable<Movie>
        {
            public string Title { get; set; }
            public Director Director { get; set; }
            public string Country { get; set; }
            public Genre Genre { get; set; }
            public int Year { get; set; }
            public byte Rating { get; set; }

            public object Clone()
            {
                return new Movie
                {
                    Title = Title,
                    Director = (Director)Director.Clone(),
                    Country = Country,
                    Genre = Genre,
                    Year = Year,
                    Rating = Rating
                };
            }

            public int CompareTo(Movie other)
            {
                if (other == null) return 1;
                return this.Year.CompareTo(other.Year);
            }

            public override string ToString()
            {
                return $"Title: {Title}, Director: {Director}, Country: {Country}, Genre: {Genre}, Year: {Year}, Rating: {Rating}";
            }
        }

        class MovieComparer : IComparer<Movie>
        {
            public int Compare(Movie x, Movie y)
            {
                if (x == null || y == null)
                {
                    return 0;
                }

                return x.Year.CompareTo(y.Year);
            }
        }
    }
}
