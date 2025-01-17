using System;
using System.Diagnostics.Metrics;
using MovieManager.Framework;

namespace MovieManager
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("------- MOVIE MANAGER -------");

            while (true)
            {
                Console.Write(">>> ");
                var route = Console.ReadLine();
                Router.Forward(route);
            }
        }
    }
}
