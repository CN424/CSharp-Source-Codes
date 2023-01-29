using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("What type of calculation do you want to perform? (+, -, *, or /) ");
                string calculation = Console.ReadLine();

                Console.WriteLine("Write the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Write the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (calculation)
                {
                    case "+":
                        int add = num1 + num2;
                        Console.Write("The answer is {0}", add);
                        break;
                    case "-":
                        int subtract = num1 - num2;
                        Console.Write("The answer is {0}", subtract);
                        break;
                    case "*":
                        int multiply = num1 * num2;
                        Console.Write("The answer is {0}", multiply);
                        break;
                    case "/":
                        int divide = num1 / num2;
                        Console.Write("The answer is {0}", divide);
                        break;
                }
            Console.WriteLine("Write 'yes' to start the application again: ");
            string ans = Console.ReadLine();
            
            if (ans || "yes");
            {

            }
            else
            {
                Console.WriteLine("");
            }
            }
        }
    }
