using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager.Controllers;

namespace MovieManager.Framework
{
    internal static class Router
    {
        private static readonly MovieController MovieController = new();
        private static readonly MainController MainController = new();

        public static void Forward(string query)
        {
            var route = query.Trim().ToLower();

            switch (route)
            {
                case "help":
                    MainController.Help();
                    break;
                case "clear":
                    MainController.Clear();
                    break;
                case "list":
                    MovieController.List();
                    break;
                case "add":
                    MovieController.Add();
                    break;
                case "remove":
                    MovieController.Remove();
                    break;
                default:
                    Console.WriteLine("Unknown command. Type 'help' for a list of commands.");
                    break;
            }
        }
    }
}
