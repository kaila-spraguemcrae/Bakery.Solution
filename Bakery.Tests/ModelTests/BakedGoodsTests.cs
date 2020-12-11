using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void Bread_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void Bread_CreatesInstanceOfBreadPrice_Int()
    {
      Bread newBread = new Bread(1);
      int result = newBread.Price;
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void Bread_ReturnsQuantity_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);
      int result = newBread.Quantity;
      Assert.AreEqual(quantity, result);
    }
    [TestMethod]
    public void Bread_CreatesInstanceOfBreadTotal_Int()
    {
      Bread newBread = new Bread(1);
      int result = newBread.Total;
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void BreadTotal_CalculateTotal_Int()
    {
      int quantity = 5;
      Bread newBread = new Bread(quantity);
      Assert.AreEqual(20, newBread.BreadTotal(quantity));
    }


// Tests for Pastry
    [TestMethod]
    public void Pastry_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void Pastry_CreatesInstanceOfPastryPrice_Int()
    {
      Pastry newPastry = new Pastry(1);
      int result = newPastry.Price;
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void Pastry_ReturnsQuantity_Int()
    {
      int quantity = 1;
      Pastry newPastry = new Pastry(quantity);
      int result = newPastry.Quantity;
      Assert.AreEqual(quantity, result);
    }
    [TestMethod]
    public void Pastry_CreatesInstanceOfPastryTotal_Int()
    {
      Pastry newPastry = new Pastry(1);
      int result = newPastry.Total;
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void Pastry_CalculatePastryTotal_Int()
    {
      int quantity = 5;
      Pastry newPastry = new Pastry(quantity);
      Assert.AreEqual(9, newPastry.PastryTotal(quantity));
    }

//Tests for Order
    [TestMethod]
    public void Order_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order(1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void Order_CreatesInstanceOfOrderBreadTotal_Int()
    {
      int quantity = 5;
      Bread newBread = new Bread(quantity);
      newBread.BreadTotal(newBread.Quantity);
      int breadTotal = newBread.Total;
      Order newOrder = new Order(breadTotal);
      int result =  newOrder.BreadTotal;
      Assert.AreEqual(breadTotal, result);
    }
  }
}