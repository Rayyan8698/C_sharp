using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Enter an operator (+, -, *, /): ");
                char op;
                if (char.TryParse(Console.ReadLine(), out op))
                {
                    Console.Write("Enter second number: ");
                    if (double.TryParse(Console.ReadLine(), out double num2))
                    {
                        double result = 0;
                        bool valid = true;

                        switch (op)
                        {
                            case '+':
                                result = num1 + num2;
                                break;
                            case '-':
                                result = num1 - num2;
                                break;
                            case '*':
                                result = num1 * num2;
                                break;
                            case '/':
                                if (num2 != 0)
                                {
                                    result = num1 / num2;
                                }
                                else
                                {
                                    Console.WriteLine("Error: Division by zero is not allowed.");
                                    valid = false;
                                }
                                break;
                            default:
                                Console.WriteLine("Error: Invalid operator.");
                                valid = false;
                                break;
                        }

                        if (valid)
                        {
                            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid second number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operator.");
                }
            }
            else
            {
                Console.WriteLine("Invalid first number.");
            }
        }
    }
}
