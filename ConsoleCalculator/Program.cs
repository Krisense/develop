using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /):");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
 
    		if (num2 != 0)
    		{
        		result = num1 / num2;
    		}
    		else
    		{
        		Console.WriteLine("Error: Division by zero");
    		}
    		break;

		case "square":
    			result = num1 * num1;
    			break;
 
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
