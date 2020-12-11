using System;

namespace Bread.Models
{
  public class BreadOrder
  {
    public int Loaves { get; set; }

    public BreadOrder(int loaves)
    {
      Loaves = loaves;
    }

    public int GetCost(int loaves)
    {
      int cost = 0;
      if (loaves < 2)
      {
        cost = loaves*5;
      }
      else if (loaves >= 2)
      {
        cost = (loaves*5)*(2/3);
      }
      return cost;
    }

  }
}