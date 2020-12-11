using System;

namespace Bread.Models
{
  public class BreadOrder
  {
    public int Loaves { get; }

    public BreadOrder(int loaves)
    {
      Loaves = loaves;
    }
  }
}