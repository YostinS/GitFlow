using System;
using System.Collections.Generic;
namespace GitFlow_CRUD
{
    class Program
    {
        static List<string> games = new List<string>();
        private static void Menu()
        {
            
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("                             Game Center Menu  ");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("Options");
                Console.WriteLine("|   1. Add game        | 2. See games     | 3. Update game |");
                Console.WriteLine("|   4. Delete game     | 5. Read manual   | 6. Exit        |");
                Console.WriteLine("Select an option (1-6): ");
                Console.WriteLine("--------------------------------------------------------------------------");

                int answer;
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    switch (answer)
                    {
                        case 1:
                            AddGame();
                            break;
                        case 2:
                            SeeGame();
                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                        case 5:


                            break;
                        case 6:

                            exit = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }

            }
        }
        private static void AddGame()
        {
            Console.WriteLine("Enter the name of the game. When you want to finish, type 'done': ");
            while (true)
            {
                Console.WriteLine("Add game: ");
                string gameName = Console.ReadLine();
                if (gameName.ToLower() == "done")
                {
                    break;
                }
                games.Add(new string(gameName));
                Console.WriteLine($"\nSaved {games.Count} games.");

            }
        }
        private static void SeeGame()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("----------- List of games -----------");
            if (games.Count == 0)
            {
                Console.WriteLine("No games found.");
            }
            else
            {
                for (int i = 0; i < games.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {games[i]}");
                }
            }
            Console.WriteLine("-------------------------------------");
        }

        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }

    }
}