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
  }
}