using System;
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

    public static List<Prime> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    // public bool IsPrimeSOE(int num)
    // { 
    //   for (int i = 2; i < Math.Sqrt(num) + 1; i++)
    //   {
    //     bool prime = true;
    //     if (prime) 
    //     {
    //       for (int j = (int) Math.Pow(i,2); j < num; j+=i) 
    //       {
    //         prime = false;
    //       }
    //       return prime;
    //     }
    //     else
    //     {
    //       return false;
    //     }  
    //   }
    //   return true;
    // }
  }
}