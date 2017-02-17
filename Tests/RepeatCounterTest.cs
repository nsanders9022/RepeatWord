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
    public void CountRepeats_SingleWord_one()
    {
      //Arrange
      string sentInput = "bananas";
      string wordInput = "bananas";
      RepeatCounter newCounter = new RepeatCounter(sentInput, wordInput);

      //Act
      int result = newCounter.CountRepeats(sentInput, wordInput);

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

      //Assert
      Assert.Equal(1, result);
    }

    [Fact]
    public void CountRepeats_MultiWordsMultiCount_two()
    {
      //Arrange
      string sentInput = "monkeys like to eat bananas for breakfast and bananas for dinner";
      string wordInput = "bananas";
      RepeatCounter newCounter = new RepeatCounter(sentInput, wordInput);

      //Act
      int result = newCounter.CountRepeats(sentInput, wordInput);

      //Assert
      Assert.Equal(2, result);
    }

    [Fact]
    public void CountRepeats_MultiWordsError_zero()
    {
      //Arrange
      string sentInput = "monkeys like to eat bananas";
      string wordInput = "apples";
      RepeatCounter newCounter = new RepeatCounter(sentInput, wordInput);

      //Act
      int result = newCounter.CountRepeats(sentInput, wordInput);

      //Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void CountRepeats_MultiWordsCloseMatchError_zero()
    {
      //Arrange
      string sentInput = "monkeys like to eat bananas";
      string wordInput = "banana";
      RepeatCounter newCounter = new RepeatCounter(sentInput, wordInput);

      //Act
      int result = newCounter.CountRepeats(sentInput, wordInput);

      //Assert
      Assert.Equal(0, result);
    }

  }
}
