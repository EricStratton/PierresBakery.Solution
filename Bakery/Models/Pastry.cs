using System;

namespace Pastry.Models
{
  public class PastryOrder
  {
    public int Pastries { get; set; }

    public PastryOrder(int pastries)
    {
      Pastries = pastries;
    }

    public int GetCost(int pastries)
    {
      int cost = 0;
      int discountPastries = 0;
      if (pastries % 3 == 0)
      {
        discountPastries = pastries / 3;
      }
      else
      {
        int remainder = pastries % 3;
        discountPastries = (pastries - remainder) / 3;
      }

      if (pastries <= 2)
      {
        cost = pastries * 2;
      }
      else if (pastries > 2)
      {
        cost = (pastries - discountPastries) * 2 + discountPastries;
      }
      return cost;
    }
  }
}