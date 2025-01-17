using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.Views
{
    internal class MainView
    {
        public void HelpView()
        {
            Console.WriteLine("\n--------- HELP ---------");
            Console.WriteLine(" List - Show the list of movies");
            Console.WriteLine(" Add - Add a new movie");
            Console.WriteLine(" Remove - Remove a movie by ID");
            Console.WriteLine(" Clear - Clear the console");
            Console.WriteLine(" Help - Show this help");
            Console.WriteLine("------------------------");
        }
    }
}
