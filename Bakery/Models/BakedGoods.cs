using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Bread(int quantity)
    {
      Price = 5;
      Quantity = quantity;
    }

    public int BreadTotal(int quantity)
    {
      int total = (quantity * 5) - ((quantity / 3) * 5);
      return total;
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
  }
}