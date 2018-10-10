using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab6
{
    class Program
    {
        static void Main()
        {
            int sides;
            int rollNumber = 1;
            string rollAgain = "Y";
            Random dice = new Random();
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            Console.Write("Would you like to roll the dice? Y/N: ");
            string answer = Console.ReadLine().ToUpper();
            while(answer != "Y" && answer != "YES" && answer != "N" && answer != "NO")
            {
                Console.WriteLine("Invalid selection. Would you like to roll the dice? Y/N: ");
                answer = Console.ReadLine().ToUpper();
            }


            if (answer == "Y" || answer == "YES")
            {
                while (rollAgain == "Y" || rollAgain == "YES")
                {
                    Console.Write("How many sides does your dice have? ");

                    while (!int.TryParse(Console.ReadLine(), out sides) || sides < 2)
                        Console.Write("Invalid selection.  How many sides does your dice have? ");
                    Console.WriteLine("\n");
                    Console.WriteLine("Roll " + rollNumber + ":");
                    int roll1 = Roll(dice, sides);
                    int roll2 = Roll(dice, sides);
                    Console.WriteLine(roll1);
                    Console.WriteLine(roll2);

                    if (roll1 == 1 && roll2 == 1)
                    { Console.WriteLine("Craps and Snake Eyes!"); }

                    if (roll1 == 6 && roll2 == 6)
                    { Console.WriteLine("Craps and Box Cars!"); }

                    if (roll1 + roll2 == 3)
                    { Console.WriteLine("Craps!"); }

                    Console.WriteLine("\n");
                    Console.Write("Roll again? Y/N: ");
                    rollAgain = Console.ReadLine().ToUpper();
                    while (rollAgain != "Y" && rollAgain != "YES" && rollAgain != "N" && rollAgain != "NO")
                    {
                        Console.Write("Invalid selection. Roll again? Y/N: ");
                        rollAgain = Console.ReadLine().ToUpper();
                    }
                    if (rollAgain == "Y" || rollAgain == "YES")
                        rollNumber += 1;
                    Console.WriteLine("\n");
                }
                Console.WriteLine("Ok, goodbye!");
            }
            else
            {
                Console.WriteLine("Ok, goodbye!");
            }

                Console.ReadKey();
            
        }
        public static int Roll(Random dice, int numberOfSides)
        {
            int roll = dice.Next(1, numberOfSides+1);
            return roll;
        }
    }
}
