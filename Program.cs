using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main(string[] args)
    {
      int breadQuantity = GetUserInput("How many loaves of bread would you like?");
      Bread bread = new Bread(breadQuantity);

      int pastryQuantity = GetUserInput("How many pastries would you like?");
      Pastry pastry = new Pastry(pastryQuantity);

      int breadPrice = bread.CalculatePrice();
      int pastryPrice = pastry.CalculatePrice();
      int totalPrice = breadPrice + pastryPrice;

      Console.WriteLine($"Your total is ${totalPrice}.");
    }

    static void DisplayWelcomeMessage()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine("Pastry: Buy 3, get 1 free. A single pastry costs $2.");
    }

    static int GetUserInput(string prompt)
    {
      int result;
      string input;
      Console.Write(prompt);
      input = Console.ReadLine() ?? "";

      while (!int.TryParse(input, out result) || result < 0)
       {
         Console.WriteLine("Invalid input. Please enter a non-negative number.");
         Console.Write(prompt);
         input = Console.ReadLine() ?? "";
        }

      return result;
    }
  }
}
