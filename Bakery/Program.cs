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
      Console.WriteLine("Pastries cost 2$ each, or 5$ for 3, deal can be applied to any amount.");
      Console.WriteLine("How many pastries would you like?"); // Attempt catch block
      string strPastryOrder = Console.ReadLine();
      int pastryOrder;
        try 
        {
          int.Parse(strPastryOrder);
        }
        catch (NotANumberException e)
        {
          Console.WriteLine($"Sorry, that doesn't seem to be a number. Try again: {e}\n");
        }
        finally
        {
          pastryOrder = int.Parse(strPastryOrder);
        }
      PastryOrder newPastryOrder = new PastryOrder(pastryOrder);
      Console.WriteLine($"You've ordered {newPastryOrder.Pastries} pastries, is this correct? (Y/N)");
      string correctPastries = Console.ReadLine();
      if (correctPastries == "y" || correctPastries == "Y")
      {
        Console.WriteLine("Okay your total cost for those pastries will be: ");
        int pastryOrderTotal = newPastryOrder.GetCost(newPastryOrder.Pastries);
        Console.WriteLine($"${pastryOrderTotal}\n");
        Main();
      }
      else if (correctPastries == "n" || correctPastries == "N")
      {
        Console.WriteLine("Okay, lets try again.\n");
        PastryOrder();
      }
      else
      {
        Console.WriteLine("Oops, something went wrong. Let's try again.\n");
        PastryOrder();
      }
    }

    public static void BreadOrder()
    {
      Console.WriteLine("Okay, grab some of our world famous bread!");
      Console.WriteLine("Loaves of bread cost $5 each, but if you buy 2 we'll throw in a third free, applicable on any order size.");
      Console.WriteLine("How many loaves of bread would you like?"); // Attempt catch block
      string strBreadOrder = Console.ReadLine();
      int breadOrder = int.Parse(strBreadOrder);
      BreadOrder newBreadOrder = new BreadOrder(breadOrder);
      Console.WriteLine($"You've ordered {newBreadOrder.Loaves} loaves of bread, is this correct? (Y/N)");
      string correctLoaves = Console.ReadLine();
      if (correctLoaves == "y" || correctLoaves == "Y")
      {
        Console.WriteLine("Okay your total cost for those loaves of bread comes to: ");
        int loavesOrderTotal = newBreadOrder.GetCost(newBreadOrder.Loaves);
        Console.WriteLine($"${loavesOrderTotal}\n");
        Main();
      }
      else if (correctLoaves == "n" || correctLoaves == "N")
      {
        Console.WriteLine("Okay, lets try again.\n");
        BreadOrder();
      }
      else
      {
        Console.WriteLine("Oops, something went wrong. Let's try again.\n");
        BreadOrder();
      }
    }

    public class NotANumberException: Exception 
    {
      public NotANumberException(string message): base(message) {}
    }
  }
}