using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppWithClassLibrary;

namespace MoviePresentationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Movie store application");
            MovieController movieController = new MovieController();
            movieController.Start();

        }
    }
}
