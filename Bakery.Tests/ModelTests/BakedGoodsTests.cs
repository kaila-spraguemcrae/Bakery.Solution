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
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void Bread_CreatesInstanceOfBreadPrice_Bread()
    {
      Bread newBread = new Bread();
      int result = newBread.Price;
      Assert.AreEqual(5, result);
    }
  }
}