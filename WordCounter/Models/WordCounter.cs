using System;
using System.Collections.Generic;
using System.Text;

namespace Counter.Models
{
  public class RepeatCounter
  {
    public static string AcceptWord(string word)
    {
      return word;
    }

    public static string AcceptSentence(string sentence)
    {
      return sentence;
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

		public static int CompareWord(string word, string sentence)
		{
		string wordToCompare = AcceptWord(word);
		string sentenceToCompare = AcceptSentence(sentence);
		string sentenceRemovePunct = RemovePunctuation(sentenceToCompare);
		string [] compareSentence = sentenceRemovePunct.Split(' ');
		int num = 0;
	
		for (int i = 0; i < compareSentence.Length; i++)
		{
			if (compareSentence[i] == wordToCompare)
			{
				num++;
			}
		}
		return num;
		}
  }
}