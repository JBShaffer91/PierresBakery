using System;
using PierresBakery.Models;

namespace PierresBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeMessage();

            Console.Write("Enter the number of loaves of bread: ");
            int breadQuantity = int.Parse(Console.ReadLine());
            Bread bread = new Bread(breadQuantity);

            Console.Write("Enter the number of pastries: ");
            int pastryQuantity = int.Parse(Console.ReadLine());
            Pastry pastry = new Pastry(pastryQuantity);

            int breadCost = bread.CalculatePrice();
            int pastryCost = pastry.CalculatePrice();
            int totalCost = breadCost + pastryCost;

            Console.WriteLine($"Total cost of your order: ${totalCost}");
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
            Console.WriteLine("Pastry: Buy 3, get 1 free. A single pastry costs $2.");
        }
    }
}
