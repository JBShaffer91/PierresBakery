using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main(string[] args)
    {
      DisplayWelcomeMessage();
    }

    static void DisplayWelcomeMessage()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We sell bread and pastries.");
      Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine("Pastry: Buy 3, get 1 free. A single pastry costs $2.");
    }

    static void Main(string[] args)
    {
      DisplayWelcomeMessage();

      Console.Write("How many loaves of bread would you like? ");
      int breadQuantity = int.Parse(Console.ReadLine());

      Console.Write("How many pastries would you like? ");
      int pastryQuantity = int.Parse(Console.ReadLine());
      Pastry pastry = new Pastry(pastryQuantity);

      int breadCost = bread.CalculatePrice();
      int pastryCost = pastry.CalculatePrice();
      int totalCost = breadCost + pastryCost;

      Console.WriteLine("Your total is $" + totalCost);
    }
  }
}