namespace Bakery.Models
{
  public class Order
  {
    public int BreadTotal { get; set; }
    public int PastryTotal { get; set; }

    public Order(int breadTotal, int pastryTotal)
    {
      BreadTotal = breadTotal;
      PastryTotal = pastryTotal;
    }
    public int Total(int num1, int num2)
    {
      int total = num1 + num2;
      return total;
    }
  }
}