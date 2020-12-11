using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
    {
    public static void Main()
    {
      Console.WriteLine("-----------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("-----------------------------");

      Console.WriteLine("Would you like to purchase our fresh bread or pastries (Bread/Pastry):");
      string response1 = Console.ReadLine().ToLower();
      if (response1 == "bread")
      {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("SALE: Buy two loafs of bread get one free. A single loaf costs $5");
      } 
      else if (response1 == "pastry")
      {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("SALE: Buy one pastry for $2 or get three for $5");
      }
      else
      {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("There was a problem...Please check your response and try again...");
        Console.WriteLine("Would you like to start over? (Yes/No)");
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