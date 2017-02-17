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

    [Fact]
<<<<<<< HEAD
    public void CountRepeats_DoubleLetter_one()
=======
    public void CountRepeats_SingleWord_one()
>>>>>>> 456a571cbd8a431d9f406af5f1393f8ebbb44935
    {
      //Arrange
      string sentInput = "bananas";
      string wordInput = "bananas";
      RepeatCounter newCounter = new RepeatCounter(sentInput, wordInput);

      //Act
      int result = newCounter.CountRepeats(sentInput, wordInput);
<<<<<<< HEAD

      //Assert
      Assert.Equal(1, result);
    }

    [Fact]
    public void CountRepeats_MultiWords_one()
    {
      //Arrange
      string sentInput = "monkeys like to eat bananas";
      string wordInput = "bananas";
      RepeatCounter newCounter = new RepeatCounter(sentInput, wordInput);

      //Act
      int result = newCounter.CountRepeats(sentInput, wordInput);
=======
>>>>>>> 456a571cbd8a431d9f406af5f1393f8ebbb44935

      //Assert
      Assert.Equal(1, result);
    }

  }
}
