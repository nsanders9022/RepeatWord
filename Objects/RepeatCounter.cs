using System;
using System.Collections.Generic;

namespace RepeatCounterApp.Objects
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _word;

    public RepeatCounter(string sentence, string word)
    {
      _sentence = sentence;
      _word = word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public string GetWord()
    {
      return _word;
    }

    public int CountRepeats(string sentenceInput, string wordInput)
    {
      //Gets rid of punctuation
      List<char> noPunctList = new List<char>{};
      char[] sentenceArray = sentenceInput.ToCharArray();

      for (int i = 0; i < sentenceArray.Length; i++)
      {
        if (Char.IsPunctuation(sentenceInput, i) == false)
        {
          noPunctList.Add(sentenceArray[i]);
        }
      }
      string sentence = string.Join("", noPunctList.ToArray());

      //main part of method for comparing words
      int counter = 0;
      sentence = sentence.ToLower();
      wordInput = wordInput.ToLower();
      string[] wordArray = sentence.Split(null);

      foreach (string word in wordArray)
      {
        if (word == wordInput)
        {
          counter += 1;
        }
      }
      return counter;

    }
  }
}
