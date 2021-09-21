using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("Welcome to Calculator\n");
            while (running)
            {
                Console.WriteLine("Choose one of the alternatives:\n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - End application");
                try
                {
                    int userInput = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine();
                    if (userInput > 0 && userInput < 6)
                    {
                        bool isNumber = false;
                        while (!isNumber)
                        {
                            try
                            {
                                Console.WriteLine();
                                Console.WriteLine("Enter the first number:");
                                double firstNumber = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("\nEnter the second number:");
                                double secondNumber = Convert.ToDouble(Console.ReadLine());
                                isNumber = true;
                            }
                            catch
                            {
                                Console.WriteLine("You must enter a digit or decimal number! Try again.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You must enter a digit between 1-5! Try again.\n");
                    }
                }
                catch
                {
                    Console.WriteLine("\nYou must enter a digit! Try again.\n");
                }
            }
        }
        static int GetNumberFromUser()
        {
            return 0;
        }
    }
}
