using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("---------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("---------------------");
      Console.WriteLine("Today we have fresh loaves of bread and pastries!");
      Console.WriteLine("Current Prices & Sales:");
      Console.WriteLine("Bread Single: $5.00");
      Console.WriteLine("~Bread Sale~");
      Console.WriteLine("Buy two loaves of bread get one free.");
      Console.WriteLine("---------------------");
      Console.WriteLine("Pastry Single: $2.00");
      Console.WriteLine("~Pastry Sale~");
      Console.WriteLine("Get three pastries for $5.00");
      Console.WriteLine("---------------------");
      Console.WriteLine("WHAT WOULD YOU LIKE TO DO?");
      Console.WriteLine("Add to order or view order (Add/View):");

      string response1 = Console.ReadLine().ToUpper();
      if (response1 == "ADD")
      {

      } 
      else if (response1 == "VIEW")
      {

      }
      else
      {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("There was a problem...Please check your response and try again...");
        Console.WriteLine("Would you like to try again? (Yes/No):");
        string restart = Console.ReadLine().ToLower();
        if(restart == "yes")
        {
          Program.Main();
        }
        else
        {
          Console.WriteLine("Thank you!");
        }
      }
    }
  }
}

      // {
      //   Console.WriteLine("-----------------------------");
      //   Console.WriteLine("SALE: Buy two loaves of bread get one free. A single loaf costs $5");
      //   Console.WriteLine("How many loaves of bread would you like to order?");
      //   Console.WriteLine("Please enter a quantity:");
      //   int breadQuantity = int.Parse(Console.ReadLine());

      //   if (breadQuantity >= 0)
      //   {
      //     Bread newBread = new Bread(breadQuantity);
      //     newBread.BreadTotal(breadQuantity);
      //     Console.WriteLine("Your order of " + newBread.Quantity + " loaves of bread has been added to your order");
      //     Console.WriteLine("The total price for " + newBread.Quantity + " loaves is $" + newBread.Total + ".00");
      //   }
      //   else
      //   {
      //     Console.WriteLine("-----------------------------");
      //     Console.WriteLine("There was a problem...Please check your response and try again...");
      //     Console.WriteLine("Would you like to start over? (Yes/No):");
      //     string restart = Console.ReadLine().ToLower();

      //     if(restart == "yes")
      //     {
      //       Program.Main();
      //     }
      //     else
      //     {
      //       Console.WriteLine("Thank you!");
      //     }
      //   } 
      // }
      // else if (response1 == "pastry")
      // {
      //   Console.WriteLine("-----------------------------");
      //   Console.WriteLine("SALE: Buy one pastry for $2 or get three for $5");
      // }