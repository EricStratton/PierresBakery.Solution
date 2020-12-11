using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bread.Models;

namespace Bread.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrderConstructor_CreatesInstanceOfBreadOrder_Order()
    {
      BreadOrder newBreadOrder = new BreadOrder(0);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadOrder_Int()
    {
      int breadOrder = 3;
      BreadOrder newBreadOrder = new BreadOrder(3);
      int result = newBreadOrder.Loaves;
      Assert.AreEqual(breadOrder, result);
    }

    [TestMethod]
    public void GetCost_ReturnsBreadOrderPrice_Int()
    {
      BreadOrder newBreadOrder = new BreadOrder(13);
      int cost = newBreadOrder.GetCost(newBreadOrder.Loaves);
      Console.WriteLine(cost);
      Assert.AreEqual(45, cost);
    }
  }
}