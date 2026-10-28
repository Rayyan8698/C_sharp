using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the purchase amount: ");
            if (double.TryParse(Console.ReadLine(), out double amount) && amount >= 0)
            {
                double discountPercentage = 0;

                if (amount >= 5000)
                {
                    discountPercentage = 20;
                }
                else if (amount >= 2000)
                {
                    discountPercentage = 10;
                }
                else
                {
                    discountPercentage = 0;
                }

                double discountAmount = amount * (discountPercentage / 100.0);
                double finalAmount = amount - discountAmount;

                Console.WriteLine($"Discount Percentage: {discountPercentage}%");
                Console.WriteLine($"Discount Amount: {discountAmount:F2}");
                Console.WriteLine($"Final Payable Amount: {finalAmount:F2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid non-negative amount.");
            }  
        }
    }
}
