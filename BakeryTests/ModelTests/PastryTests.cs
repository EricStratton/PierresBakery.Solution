using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pastry.Models;

namespace Pastry.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void PastryOrderConstructor_CreatesInstanceOfPastryOrder_Order()
    {
      PastryOrder newPastryOrder = new PastryOrder();
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }
  }
}