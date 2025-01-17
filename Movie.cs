using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.Models
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
    }
}
