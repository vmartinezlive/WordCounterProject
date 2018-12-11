using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System;

namespace WordCounter.Models
{
  public class Word
  {
    private string _word;
    private string _sentence;
    // private string _phrase = "I ate the apple from the appletree";
    // private string[] words = phrase.Split(' ');
    public Word(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
      // -phrase = phrase;
    }
    public string GetWord()
    {
      return _word;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public bool CompareWord(string word)
    {
      if(_word == word)
      {
        return true;
      }
      return false;
    }
    public int CountWords()
    {
      int count = 0; // need to create variable to keep track of how many times the word occurs
      string[] words = _sentence.Split(' '); //need to create array of sentence from user splitting the words to array into variable words.

      foreach(string word in words)// create for loop of word in the new variable words (which is sentence.split)
      {
        //logic for counting each word that matches test word
        if(_word == word) // create if stament to verify if _word is equal to word.
        {
          count++; // once the word is found this will count how many similar words is listed.
        }
        System.Console.WriteLine($"{word}");  //this will console write all the words in the sample sentence in array
      }

      return count;
    }

  }
}
