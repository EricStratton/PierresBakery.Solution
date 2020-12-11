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
        if (pOrB == "p" || pOrB == "P")
        {
          PastryOrder();
        }
        else if (pOrB == "b" || pOrB == "B")
        {
          BreadOrder();
        }
        else
        {
          Console.WriteLine("Oops, something went wrong. We are sorry, but please try again!");
          Main();
        }
      }
      else
      {
        Console.WriteLine("Okay, hope to see you soon!");
      }
    }

    public static void PastryOrder()
    {
      Console.WriteLine("Our pastries are some of the best in town!");
      Console.WriteLine("Pastries cost 2$ each, or 5$ for 3, deal can be applied to any amount!");
      Console.WriteLine("How many pastries would you like?");
      string strPastryOrder = Console.ReadLine();
      int pastryOrder = int.Parse(strPastryOrder);
      PastryOrder newPastryOrder = new PastryOrder(pastryOrder);
      Console.WriteLine($"You've ordered {newPastryOrder.Pastries} pastries, is this correct? (Y/N)");
      string correctPastries = Console.ReadLine();
      if (correctPastries == "y" || correctPastries == "Y")
      {
        Console.WriteLine("Okay your total cost for those pastries will be: ");
        int pastryOrderTotal = newPastryOrder.GetCost(newPastryOrder.Pastries);
        Console.WriteLine($"${pastryOrderTotal}");
        Main();
      }
      else if (correctPastries == "n" || correctPastries == "N")
      {
        Console.WriteLine("Okay, lets try again.");
        Main();
      }
    }

    public static void BreadOrder()
    {

    }
  }
}