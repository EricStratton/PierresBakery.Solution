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
      BreadOrder newBreadOrder = new BreadOrder();
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }
  }
}