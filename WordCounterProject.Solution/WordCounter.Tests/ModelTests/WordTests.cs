using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void Constructor_SetsWordAndSentence_True()
    {
      // Arrange
      string testSentence = "I took apple from the appletree";
      string testWord = "apple";
      Word newWord = new Word(testWord, testSentence);

      //Act
      Assert.AreEqual("apple", newWord.GetWord());
      Assert.AreEqual("I took apple from the appletree", newWord.GetSentence());
    }
    [TestMethod]
    public void CompareWord_ChecksIfWordsAreTheSame_True()
    {
      // Arrange
      string testSentence = "I took apple from the appletree";
      string testWord = "apple";
      Word newWord = new Word(testWord, testSentence);
      //Act
      bool actualResult = newWord.CompareWord("apple");
      bool expectedResult = true;

      //Act
      Assert.AreEqual(expectedResult, actualResult);
    }
    [TestMethod]
    public void CountWords_CountsTheNumberOfApplesInSentence_Int()
    {
      // Arrange
      string testSentence = "I took apple from the appletree";
      string testWord = "apple";
      Word newWord = new Word(testWord, testSentence);

      //Act
      int actualResult = newWord.CountWords();
      int expectedResult = 1;

      //Act
      Assert.AreEqual(expectedResult, actualResult);
    }

  }
}
