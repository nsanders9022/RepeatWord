using Xunit;
using RepeatCounterApp.Objects;
using System;
using System.Collections.Generic;

namespace RepeatCounterApp
{
  public class RepeatCounterTest
  {

    [Fact]
    public void CountRepeats_SingleLetter_one()
    {
      //Arrange
      string sentInput = "a";
      string wordInput = "a";
      RepeatCounter newCounter = new RepeatCounter(sentInput, wordInput);

      //Act
      int result = newCounter.CountRepeats(sentInput, wordInput);

      //Assert
      Assert.Equal(1, result);
    }

  }
}
