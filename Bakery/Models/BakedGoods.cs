using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int Quantity { get; set; }
    public int Total { get; set; }

    public Bread(int quantity)
    {
      Price = 5;
      Quantity = quantity;
      Total = 0;
    }

    public int BreadTotal(int quantity)
    {
      Total = (quantity * 5) - ((quantity / 3) * 5);
      return Total;
    }
  }

  public class Pastry
  {
    public int Price { get; set; }
    public int Quantity { get; set; }
    public int Total { get; set; }
  
    public Pastry(int quantity)
    {
      Price = 2;
      Quantity = quantity;
      Total = 0;
    }
    public int PastryTotal(int quantity)
    {
      Total = (quantity * 2) - ((quantity / 3) * 1);
      return Total;
    }
  }
}