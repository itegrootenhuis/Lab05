using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice simulator.");
            UserInputForDiceSides();
        }

        private static void UserInputForDiceSides()
        {
            Console.Write("How many sides should each die have?: ");
            bool bit = int.TryParse(Console.ReadLine(), out int dieSides);

            if (bit)
                UserInputForRoll(dieSides);
            else
                InvalidInput("\nThe number of sides must be an integer. ");
        }

        private static void InvalidInput(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            QuitConsoleApp();
        }

        private static void UserInputForRoll(int dieSides)
        {
            Console.WriteLine("Would you like to roll? (y/n)");
            string rollOrNo = Console.ReadLine();

            if (rollOrNo.ToLower() == "y")
                RollDice(dieSides);
        }

        private static void RollDice(int dieSides)
        {
            Random rnd = new Random();
            int die1 = rnd.Next(1, (dieSides + 1));
            int die2 = rnd.Next(1, (dieSides + 1));

            Console.WriteLine(string.Format("The first die came out to {0}", die1));
            Console.WriteLine(string.Format("The first die came out to {0}", die2));

            QuitConsoleApp();
        }

        private static void QuitConsoleApp()
        {
            Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "r")
            {
                Console.Clear();
                UserInputForDiceSides();
            }
        }
    }
}
