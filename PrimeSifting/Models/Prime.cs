using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class Prime
  {
    public int Num { get; set; }
    private static List<Prime> _instances = new List<Prime> {};

    public Prime(int num)
    {
      Num = num;
      _instances.Add(this);
    }

    public bool IsPrime(int num)
    {
      for (int i = 2; i < num; i++)
      {
        if (num % i != 0)
        {
          i++;
        }
        else 
        {
        return false;
        }
      }
      return true; 
    }
  }
}