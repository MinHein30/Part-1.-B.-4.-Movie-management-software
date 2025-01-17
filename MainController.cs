using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager.Views;

namespace MovieManager.Controllers
{
    internal class MainController
    {
        private readonly MainView _view = new();

        public void Help()
        {
            _view.HelpView();
        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}
