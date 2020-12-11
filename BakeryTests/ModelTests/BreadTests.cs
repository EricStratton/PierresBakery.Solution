using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bread.Models;

namespace Bread.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrderConstructor_CreatesInstanceOfBreadOrder_Int()
    {
      BreadOrder newBreadOrder = new BreadOrder(3);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadOrder_Int()
    {
      int breadOrder = 3;
      BreadOrder newBreadOrder = new BreadOrder(2);
      int result = newBreadOrder.Loaves;
      Assert.AreEqual(breadOrder, result);
    }
  }
}