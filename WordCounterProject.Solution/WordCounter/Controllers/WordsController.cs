using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

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
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/word")]
    public ActionResult Create()
    {
      Word myWord = new Word();
      return RedirectToAction("Index");
    }


  }
}
