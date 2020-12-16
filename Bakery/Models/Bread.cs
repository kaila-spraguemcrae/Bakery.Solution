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
}