
namespace GitFlow_CRUD
{
    class Program
    {
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

                            break;
                        case 2:

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
                    Console.WriteLine("Entrada invalida. Por favor ingresa un numero.");
                }

            }
        }

        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }

    }
}