using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

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
  }
}