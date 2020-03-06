using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter.Models;
using System;
using System.Collections.Generic;

namespace Counter.Tests
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void AcceptWord_TakeWordAsString_ReturnString()
    {
      string testOutput = "Hello";
      string goodTest = "Hello";
      Assert.AreEqual(goodTest, RepeatCounter.AcceptWord(testOutput));
    }

  }
}