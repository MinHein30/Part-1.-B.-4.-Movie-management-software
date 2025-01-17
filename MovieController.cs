using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieManager.Models;
using MovieManager.Repositories;
using MovieManager.Views;

namespace MovieManager.Controllers
{
    internal class MovieController
    {
        private readonly MovieRepository _repository = new();
        private readonly MovieView _view = new();

        public void List()
        {
            var model = _repository.Retrieve();
            _view.ListView(model);
        }

        public void Add()
        {
            Console.Write("Enter Movie Name: ");
            var name = Console.ReadLine();

            Console.Write("Enter Movie Length (in minutes): ");
            var length = int.Parse(Console.ReadLine());

            Console.Write("Enter Year of Production: ");
            var year = int.Parse(Console.ReadLine());

            Console.Write("Enter Movie Description: ");
            var description = Console.ReadLine();

            var movie = new Movie
            {
                Id = _repository.Retrieve().Length + 1,
                Name = name,
                Length = length,
                Year = year,
                Description = description
            };
            _repository.Create(movie);

            Console.WriteLine(" -> Movie added successfully!");
        }

        public void Remove()
        {
            Console.Write("Enter the ID of the movie you want to delete: ");
            var id = int.Parse(Console.ReadLine());
            _repository.Delete(id);
            Console.WriteLine($" -> Movie with ID {id} has been removed.");
        }
    }
}
