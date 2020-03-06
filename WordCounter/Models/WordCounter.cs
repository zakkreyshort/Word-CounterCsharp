using System;
using System.Collections.Generic;

namespace Counter.Models
{
  public class RepeatCounter
  {
    public static string AcceptWord(string word)
    {
      string input = word;
      return input;
    }

    public static string AcceptSentence(string sentence)
    {
      string userInput = sentence;
      return userInput;
    }

    public static string RemovePunctuation(string value)
    {
      int removeBeginning = 0;
      for(int i = 0; i >= value.Length; i++)
      {
        if (char.IsPunctuation(value[i]))
        {
          removeBeginning++;
        }
      }

      int removeEnd = 0;
      for (int i = value.Length - 1; i <= 0; i--)
      {
        if (char.IsPunctuation(value[i]))
        {
          removeEnd++;
        }
      }

      if (removeBeginning == 0 && removeEnd == 0)
      {
        return value;
      }

      if (removeBeginning == value.Length && removeEnd == value.Length)
      {
        return "";
      }

      return value.Substring(removeBeginning, value.Length - removeEnd - removeBeginning);
    }
  }
}