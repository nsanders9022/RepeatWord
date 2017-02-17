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
      int counter = 0;
      string[] wordArray = sentenceInput.Split(null);

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
