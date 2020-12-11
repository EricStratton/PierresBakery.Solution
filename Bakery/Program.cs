using System;
using Bread.Models;
using Pastry.Models;

namespace BakeryOrder
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello, welcome to Pierre's Bakery!");
      Console.WriteLine("Would you like to place an order? (Y/N)");
      string yesOrNo = Console.ReadLine();
      if (yesOrNo == "y" || yesOrNo == "Y")
      {
        Console.WriteLine("Great, would you like to order pastries or bread? (P/B)");
        string pOrB = Console.ReadLine();
        if (pOrB == "p" || pOrB = "P")
        {
          
          Console.WriteLine("Our pastries are some of the best in town!");
          Console.WriteLine("Pastries cost 2$ per unit, or 5$ for 3, deal can be applied to any amount!");
          Console.WriteLine("How many pastries would you like?");
          string strPastryOrder = Console.ReadLine();
          int pastryOrder = int.Parse(strPastryOrder);
          PastryOrder newPastryOrder = new PastryOrder(pastryOrder);
        }
      }
    }
  }
}