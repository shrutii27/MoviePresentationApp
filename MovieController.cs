using MovieAppWithClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePresentationApp
{
    public class MovieController
    {
       private MovieManager movieManager; //Create an instance of MovieManager
            public MovieController()
           {
                movieManager = new MovieManager(); //Initialize the movieManager
            }
            public static void DisplayMenu()
            {
                Console.WriteLine("1. Display All Movies");
                Console.WriteLine("2. Add Movie");
                Console.WriteLine("3. Find Movie by Year");
                Console.WriteLine("4. Remove Movie by Name");
                Console.WriteLine("5. Clear Movie List");
                Console.WriteLine("6. Exit from the application");
                Console.Write("Enter your choice: ");
            }

            public void Start()
            {
               while (true)
              {
                  DisplayMenu();
                  int choice = Convert.ToInt32(Console.ReadLine());

                  try
                 {
                    switch (choice)
                    {
                       case 1:
                             Console.WriteLine(movieManager.DisplayMovies());
                             break;
                       case 2:
                             Console.Write("Enter movie ID: ");
                             int id = Convert.ToInt32(Console.ReadLine());

                             Console.Write("Enter movie name: ");
                             string name = Console.ReadLine();

                             Console.Write("Enter movie year: ");
                             int year = Convert.ToInt32(Console.ReadLine());

                             Console.Write("Enter movie director: ");
                             string director = Console.ReadLine();

                             Console.WriteLine(movieManager.AddMovie(id, name, year, director));
                             break;

                       case 3:
                             Console.Write("Enter the year to search for: ");
                             int yearToSearch = Convert.ToInt32(Console.ReadLine());
                             Console.WriteLine(movieManager.FindMovieByYear(yearToSearch));
                             break;
                       case 4:
                             Console.Write("Enter the name of the movie to remove: ");
                             string movieNameToRemove = Console.ReadLine();
                             Console.WriteLine(movieManager.RemoveMovieByName(movieNameToRemove));
                             break;
                       case 5:
                             Console.WriteLine(movieManager.ClearMovieList());
                             break;
                       case 6:
                             Console.WriteLine("Exit from the application.");
                             Environment.Exit(0);
                             break;

                       default:
                             Console.WriteLine("Invalid choice. Please select a valid option.");
                             break;
                       }
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine("Error" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An unexpected error occurred" + ex.Message);
                    }
                }
            }
        }
    }




