using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter.Models;
using System;
using System.Text;
using System.Collections.Generic;

namespace Counter.Tests
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void AcceptWord_TakeWordAsString_ReturnString()
    {
      string testInput = "Hello";
      string goodTest = "Hello";
      Assert.AreEqual(goodTest, RepeatCounter.AcceptWord(testInput));
    }

    [TestMethod]
    public void AcceptSentence_TakeSentenceAsString_ReturnString()
    {
      string testInput = "Hello, how are you today?";
      string goodTest = "Hello, how are you today?";
      Assert.AreEqual(goodTest, RepeatCounter.AcceptSentence(testInput));
    }

    [TestMethod]
    public void RemovePunctuation_TakeWordAsStringRemovePunctuation_ReturnString()
    {
      string testInput = "Hello, how are you today?";
      string goodTest = "Hello how are you today";
      Assert.AreEqual(goodTest, RepeatCounter.RemovePunctuation(testInput));
    }
  }
}