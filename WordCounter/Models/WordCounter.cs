using System;
using System.Collections.Generic;
using System.Text;

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
      StringBuilder sb = new StringBuilder(value.Length);
      foreach (char c in value)
      {
        if ((c >= '0' && c<='9') || (c >= 'A' && c<='Z') || (c >= 'a' && c<= 'z') || c == ' ')
        {
          sb.Append(c);
        }
      }
      return sb.ToString();
    }
  }
}