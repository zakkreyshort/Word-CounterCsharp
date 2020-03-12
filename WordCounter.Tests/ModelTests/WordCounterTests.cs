using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter.Models;


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

    [TestMethod]
    public void CompareWord_CountWordInSentence_ReturnNumber()
    {
      string testInput = "Hello, there, how are you, today! Hello Hello, Hello";
      string testWord = "there";
      int goodTestNumber = 1;
      Assert.AreEqual(goodTestNumber, RepeatCounter.CompareWord(testWord, testInput));
    }

    [TestMethod]
    public void CompareWord_IgnoreWordInsideWord_ReturnNumber()
    {
      string testInput = "Hello, aliens have taken over the world. Do not interact with an alien if you see one! I repeat, do NOT INTERACT WITH ALIEN";
      string testWord = "alien";
      int goodTestNumber = 1;
      Assert.AreEqual(goodTestNumber, RepeatCounter.CompareWord(testWord, testInput));
    }
  }
}