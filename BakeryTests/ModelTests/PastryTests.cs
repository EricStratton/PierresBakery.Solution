using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pastry.Models;

namespace Pastry.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void PastryOrderConstructor_CreatesInstanceOfPastryOrder_Order()
    {
      PastryOrder newPastryOrder = new PastryOrder(0);
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }

    [TestMethod]
    public void GetPastryOrder_ReturnsPastryOrder_Int()
    {
      int pastryOrder = 3;
      PastryOrder newPastryOrder = new PastryOrder(3);
      int result = newPastryOrder.Pastries;
      Assert.AreEqual(pastryOrder, result);
    }

    [TestMethod]
    public void GetCost_ReturnsPastryOrderPrice_Int()
    {
      PastryOrder newPastryOrder = new PastryOrder(13);
      int cost = newPastryOrder.GetCost(newPastryOrder.Pastries);
      Console.WriteLine(cost);
      Assert.AreEqual(22, cost);
    }
  }
}