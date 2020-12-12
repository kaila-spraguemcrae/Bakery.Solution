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
      Console.WriteLine("WOULD YOU LIKE TO CREATE A NEW ORDER? (Yes/No):");

      string response1 = Console.ReadLine().ToUpper();
      if (response1 == "YES")
      {
        Console.WriteLine("---------------------");
        Console.WriteLine("How many loaves of bread would you like?");
        Console.WriteLine("Please enter a quantity:");
        int breadQuantity = int.Parse(Console.ReadLine());
        if (breadQuantity >= 0)
        {
          Bread newBread = new Bread(breadQuantity);
          newBread.BreadTotal(breadQuantity);
        }
        else
        {
          Console.WriteLine("-----------------------------");
          Console.WriteLine("There was a problem...Please check your response and try again...");
          Console.WriteLine("Would you like to try again? (Yes/No):");
          string restart = Console.ReadLine().ToUpper();
          if(restart == "YES")
          {
            Program.Main();
          }
          else
          {
            Console.WriteLine("Thank you!");
          }
        }
        Console.WriteLine("---------------------");
        Console.WriteLine("How many pastries would you like?");
        Console.WriteLine("Please enter a quantity:");
        int pastryQuantity = int.Parse(Console.ReadLine());
        if (pastryQuantity >= 0)
        {
          Pastry newPastry = new Pastry(pastryQuantity);
          newPastry.PastryTotal(pastryQuantity);
        }
        else
        {
          Console.WriteLine("-----------------------------");
          Console.WriteLine("There was a problem...Please check your response and try again...");
          Console.WriteLine("Would you like to try again? (Yes/No):");
          string restart = Console.ReadLine().ToUpper();
          if(restart == "YES")
          {
            Program.Main();
          }
          else
          {
            Console.WriteLine("Thank you!");
          }
        }
        Console.WriteLine("---------------------");
        Console.WriteLine("The total price for " + newBread.Quantity + " loaf/loaves is $" + newBread.Total + ".00");
        Console.WriteLine("The total price for " + newPastry.Quantity + " pastry/pastries is $" + newPastryTotal + ".00");
        Console.WriteLine("---------------------");
        Console.WriteLine("Is this correct? (Yes/No)");
        string response2 = Console.ReadLine().ToUpper();
        if (response2 == "YES")
        {
          Order newOrder = new Order(Bread.Total, Pastry.Total);
          Console.WriteLine("Your total price for this order is: $" + newOrder.Total(newOrder.BreadTotal, newOrder.PastryTotal));
          Console.WriteLine("Thank you for Ordering with Pierre's Bakery!");
        } 
        else if (response2 == "NO")
        {
          Console.WriteLine("Would you like to try again? (Yes/No):");
          string restart = Console.ReadLine().ToUpper();
          if(restart == "YES")
          {
            Program.Main();
          }
          else
          {
            Console.WriteLine("Thank you!");
          }
        }
        else
        {
          Console.WriteLine("-----------------------------");
          Console.WriteLine("There was a problem...Please check your response and try again...");
          Console.WriteLine("Would you like to try again? (Yes/No):");
          string restart = Console.ReadLine().ToUpper();
          if(restart == "YES")
          {
            Program.Main();
          }
          else
          {
            Console.WriteLine("Thank you!");
          }
        }

      }
      else if (response1 == "NO")
      {
        Console.WriteLine("---------------------");
        Console.WriteLine("Thank you!");
      }
      else
      {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("There was a problem...Please check your response and try again...");
        Console.WriteLine("Would you like to try again? (Yes/No):");
        string restart = Console.ReadLine().ToUpper();
        if(restart == "YES")
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