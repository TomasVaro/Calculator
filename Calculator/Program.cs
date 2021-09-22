using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator\n");
            while (true)
            {
                Console.WriteLine("Choose one of the alternatives:\n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - End application");
                try
                {
                    int userInput = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine();
                    if (userInput > 0 && userInput < 5)
                    {
                        bool running = true;
                        while (running)
                        {
                            try
                            {
                                Console.WriteLine();
                                Console.WriteLine("Enter the first number:");
                                double firstNumber = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter the second number:");
                                double secondNumber = Convert.ToDouble(Console.ReadLine());
                                running = false;
                                switch (userInput)
                                {
                                    case 1:
                                        Addition(firstNumber, secondNumber);
                                        break;
                                    case 2:
                                        Subtraction(firstNumber, secondNumber);
                                        break;
                                    case 3:
                                        Multiplication(firstNumber, secondNumber);
                                        break;
                                    case 4:
                                        if (secondNumber != 0)
                                        {
                                            Division(firstNumber, secondNumber);
                                        }
                                        else Console.WriteLine("It's not allowed to divide by zero! Try again.\n");
                                        break;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("You must enter a digit or decimal number! Try again.");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else if (userInput == 5)
                    {
                        Console.WriteLine("\nThank you for using the application! Welcome back!");
                        break;
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
        static void Addition(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + sum + "\n");
        }
        static void Subtraction(double firstNumber, double secondNumber)
        {
            double diff = firstNumber - secondNumber;
            Console.WriteLine(firstNumber + " - " + secondNumber + " = " + diff + "\n");
        }
        static void Multiplication(double firstNumber, double secondNumber)
        {
            double prod = firstNumber * secondNumber;
            Console.WriteLine(firstNumber + " * " + secondNumber + " = " + prod + "\n");
        }
        static void Division(double firstNumber, double secondNumber)
        {
            double quotient = firstNumber / secondNumber;
            Console.WriteLine(firstNumber + " / " + secondNumber + " = " + quotient + "\n");
        }
    }
}
