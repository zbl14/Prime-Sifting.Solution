using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeTests : IDisposable
  {
    public void Dispose()
    {
      Prime.ClearAll();
    }

    [TestMethod]
    public void PrimeConstructor_CreatesInstanceOfPrime_Prime()
    {
      Prime newPrime = new Prime(2);
      Assert.AreEqual(typeof(Prime), newPrime.GetType());
    }

    [TestMethod]
    public void GetNum_ReturnsNum_Int()
    {
      int num = 2;
      Prime newPrime = new Prime(num);
      int primeNum = newPrime.Num;
      Assert.AreEqual(num, primeNum);
    }

    [TestMethod]
    public void PrimeTest_IsPrime_2IsTrue()
    {
      int num = 2;
      Prime newPrime = new Prime(num);
      int primeNum = newPrime.Num;
      Assert.AreEqual(true, newPrime.IsPrime(num));
    }

    [TestMethod]
    public void PrimeTest_IsPrime_True()
    {
      int num = 3;
      Prime newPrime = new Prime(num);
      int primeNum = newPrime.Num;
      Assert.AreEqual(true, newPrime.IsPrime(num));
    }

    [TestMethod]
    public void PrimeTest_IsPrime_False()
    {
      int num = 4;
      Prime newPrime = new Prime(num);
      int primeNum = newPrime.Num;
      Assert.AreEqual(false, newPrime.IsPrime(num));
    }

    [TestMethod]
    public void PrimeTest_ReturnPrimes_PrimeList()
    {
      int num1 = 2;
      int num2 = 3;
      Prime newPrime1 = new Prime(num1);
      Prime newPrime2 = new Prime(num2);
      List<Prime> newList = new List<Prime> {newPrime1, newPrime2};
      List<Prime> result = Prime.GetAll(); 
      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void PrimeTest_IsPrimeSOE_2IsTrue()
    // {
    //   int num = 2;
    //   Prime newPrime = new Prime(num);
    //   int primeNum = newPrime.Num;
    //   Assert.AreEqual(true, newPrime.IsPrimeSOE(num));
    // }

    // [TestMethod]
    // public void PrimeTest_IsPrimeSOE_False()
    // {
    //   int num = 4;
    //   Prime newPrime = new Prime(num);
    //   int primeNum = newPrime.Num;
    //   Assert.AreEqual(false, newPrime.IsPrimeSOE(num));
    // }
  }
}