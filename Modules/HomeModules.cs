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

      Post["/results"] = _ =>
      {
        string userSentence = Request.Form["sentence"];
        string userWord = Request.Form["word"];
        RepeatCounter newCounter = new RepeatCounter(userSentence, userWord);
        newCounter.CountRepeats(userSentence, userWord);
        return View["results.cshtml", newCounter];
      }
    }

  }
}
