using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Controllers
{
  public class WordsController : Controller
  {
    [HttpGet("/word")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/word/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/word")]
    public ActionResult Create(string inputWord, string inputSentence)
    {
      Word myWord = new Word(inputWord, inputSentence);
      int count = myWord.CountWords();
      return View("Result", count);
    }

  }
}
