
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MovieManager.Models;

namespace MovieManager.Repositories
{
    internal class MovieRepository
    {
        private List<Movie> _data = new()
        {
            new() { Id = 1, Name = "Inception", Length = 148, Year = 2010, Description = "A mind-bending thriller" },
            new() { Id = 2, Name = "Interstellar", Length = 169, Year = 2014, Description = "A journey through space and time" },
            new() { Id = 3, Name = "The Dark Knight", Length = 152, Year = 2008, Description = "The rise of the Batman" },
            new() { Id = 4, Name = "Mai", Length = 130, Year = 2024, Description = "The unfortunate life of a girl named Mai" }
        };

        public void Create(Movie movie)
        {
            _data.Add(movie);
        }

        public Movie[] Retrieve()
        {
            return _data.ToArray();
        }

        public Movie Retrieve(int id)
        {
            return _data.Find(movie => movie.Id == id);
        }

        public void Delete(int id)
        {
            var movie = _data.Find(m => m.Id == id);
            if (movie != null)
            {
                _data.Remove(movie);
            }
        }
    }
}
