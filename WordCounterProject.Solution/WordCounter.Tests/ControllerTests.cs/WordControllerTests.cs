using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      HomeController controller = new HomeController();
      //Act
      var indexView = controller.Index();
      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }


    [TestMethod]
    public void Result_ReturnsCorrectView_True()
    {
      //Arrange
      WordController controller = new WordController();

      //Act
      string inputWord = "Apple";
      string inputSentence = "I took apple from the appletree";
      ActionResult resultView = controller.Create(inputWord, inputSentence);

      //Assert
      Assert.IsInstanceOfType(resultView, typeof(ViewResult));
    }
  }
}
