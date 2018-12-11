using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Controllers
{
  public class WordController : Controller
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
      return RedirectToAction("Index");
    }

    [HttpPost("/word/delete")]
    public ActionResult Destroy()
    {
      Word.ClearAll();
      return View("Index");
      // return new EmptyResult(); Fail CorrectView test
    }

  }
}
