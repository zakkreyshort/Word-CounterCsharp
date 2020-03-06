using System;
using Counter.Models;

namespace Counter
{
  public class Program
  {
    public static void Main()
    {
     Console.WriteLine("Welcome to my word-counter project!");
     Console.WriteLine("Thank you for joining!");
     Console.WriteLine("--------------------------------");
     Console.WriteLine("Please enter a word:");
     string userWord = Console.ReadLine();
     Console.WriteLine("Please enter a sentence:");
     string userSentence = Console.ReadLine();
     int finalCount = RepeatCounter.CompareWord(userWord, userSentence);
     Console.WriteLine("Your final count is:" + finalCount);
    }
  }
}