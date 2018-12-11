using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
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
      WordsController controller = new WordsController();

      //Act
      string inputWord = "Apple";
      string inputStringToCheck = "there is a bLack caT and a white CAt in the cathedral!!";
      ActionResult resultView = controller.Result(inputLetterOrWord, inputStringToCheck);

      //Assert
      Assert.IsInstanceOfType(resultView, typeof(ViewResult));
    }
  }
}
