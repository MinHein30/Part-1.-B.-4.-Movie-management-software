using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieManager.Models;

namespace MovieManager.Views
{
    internal class MovieView
    {
        public void ListView(Movie[] model)
        {
            if (model == null || model.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No movies to display.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (var movie in model)
                {
                    Console.WriteLine($"Id          : {movie.Id}");
                    Console.WriteLine($"Name        : {movie.Name}");
                    Console.WriteLine($"Length      : {movie.Length} minutes");
                    Console.WriteLine($"Year        : {movie.Year}");
                    Console.WriteLine($"Description : {movie.Description}");
                    Console.WriteLine("---------------------------------------------");
                }
                Console.ResetColor();
            }
        }
    }
}
