using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroToEF.Data;

namespace IntroToEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new DataContext();

            var movie1 = new MoviesEF
            {
                Title = "Forrest Gump",
                YearReleased = "1995",
                Genre = "Drama",
                Tagline = "Adventures of a boy's life and impactful coincidences",
                Rating = 9
            };
            dbContext.Movies.Add(movie1);


            var movie2 = new MoviesEF
            {
                Title = "Forrest Gump",
                YearReleased = "1995",
                Genre = "Drama",
                Tagline = "Adventures of a boy's life and impactful coincidences",
                Rating = 9
            };
            dbContext.Movies.Add(movie2);

            var movie3 = new MoviesEF
            {
                Title = "The Shining",
                YearReleased = "1996",
                Genre = "Horror",
                Tagline = "Encounter killers in a strange hotel",
                Rating = 8
            };
            dbContext.Movies.Add(movie3);

            var movie4 = new MoviesEF
            {
                Title = "The Neverending Story",
                YearReleased = "1995",
                Genre = "Fantasy",
                Tagline = "Adventures of a boy's life and a magical creature",
                Rating = 7
            };
            dbContext.Movies.Add(movie4);

            var movie5 = new MoviesEF
            {
                Title = "Wonder Woman",
                YearReleased = "2017",
                Genre = "Action",
                Tagline = "Female Super Hero tells her story and the impacts the future",
                Rating = 9
            };
            dbContext.Movies.Add(movie5);

            var movie6 = new MoviesEF
            {
                Title = "The Excorcist",
                YearReleased = "1978",
                Genre = "Horror",
                Tagline = "Priests attempt to exorcise a demon",
                Rating = 8
            };
            dbContext.Movies.Add(movie6);

            dbContext.SaveChanges();

            var updateRating = dbContext.Movies.Where(w => w.YearReleased == "1988");

            foreach (var movie in updateRating)
            {
                movie.Rating = 10;
            }

            var deleteMovie = dbContext.Movies.Where(w => w.Title == "The Neverending Story");
            foreach (var movie in deleteMovie)
            {
                dbContext.Movies.Remove(movie);
            }
            dbContext.SaveChanges();

            var horrorMovies = dbContext.Movies.Where(w => w.Genre == "Horror");
            Console.WriteLine("These are the Horror films in the list");
            foreach(var film in horrorMovies)
            {
                Console.WriteLine(film.Title);
            }
        }
    }
}
