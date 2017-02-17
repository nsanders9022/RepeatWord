using Nancy;
using RepeatCounterApp.Objects;
using System.Collections.Generic;

namespace RepeatCounterApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Get["/results"] = _ =>
      {
        return View["results.cshtml"];
      };

      Get["/new"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/results"] = _ =>
      {
        Dictionary<string, string> newDictionary = new Dictionary<string,string>();
        string userSentence = Request.Form["sentence"];
        string userWord = Request.Form["word"];
        RepeatCounter newCounter = new RepeatCounter(userSentence, userWord);
        int result = newCounter.CountRepeats(userSentence, userWord);
        newDictionary.Add("count", result.ToString());
        newDictionary.Add("sentence", newCounter.GetSentence());
        newDictionary.Add("word", newCounter.GetWord());

        // int result = newCounter.CountRepeats(userSentence, userWord);
        return View["results.cshtml", newDictionary];
      };
    }

  }
}
