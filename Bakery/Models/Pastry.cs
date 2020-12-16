namespace Bakery.Models
{
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