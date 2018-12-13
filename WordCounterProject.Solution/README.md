# WordCounter

#### Application where it counts how frequent the word is used in a sentence

#### By **Victoria Martinez**

## Description

Program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.)

Build out an MVC web user interface for the Word Counter application you built in last week's independent project. You should clone your repo from last week and use the same git log.

## Setup/Installation Requirements

* clone repository https://github.com/vmartinezlive/WordCounterProject.git
* open file on terminal
* open browser and run http://localhost 5000

```
WordCounter.Solution
├── README.md
├── .gitignore
└── WordCounter
    ├── WordCounter.csproj
    ├── Program.cs
    ├── Startup.cs
    ├── Controllers
    │   └── HomeController.cs
    │   └── WordController.cs
    ├── Models
    │   └── Index.cshtml
    └── Words
    |   └── DeleteAll.cshtml
    |   └── New.cshtml   
    |   └── Result.cshtml       
    └── Views
    |   └── Home
    |       └── Index.cshtml
└── WordCounter.Tests
    └── WordCounter.Tests.csproj
    └── ModelTests

```
## Objectives
### Word Counter C# Basic and Testing
* Create specs in plain english with on README
* Specs include specific input and output values and a descriptive sentence.
* Specs begin with the simplest possible behavior and progress to more complex cases, covering different input values.
* All specs are translated correctly as test methods.
* All tests are passing, and described functionality is present.

* Identify words in a word
  Input:  Apple
  Output: Apple
* Identify words in a sentence
  Input:  I see a cat
  Output: I see a cat
* Identify similar words in a sentence
  Input:  Fire! Fire! Where's the Fire?
  Output: Fire
* Change the sentence to array of strings
  Input:  Fire! Fire! Where's the Fire?
  Output: "Fire!" "Fire!" "Where's" "the" "Fire?"
* Count the number of words in sentence
  Input:  Fire! Fire! Where's the Fire?
  Output: 3

### Word Counter Basic MVC Web Apps
* The user should see a splash page when first visiting the site.
* The user should be able to navigate to the 'Word Counter' game from the splash page.
* The user should be able to fill out a form to play the 'Word Counter' game.
* The user should be able to submit this form and see how many times their provided word appears in the passage they've also provided.


## Known Bugs

There is no known issues with the program.  

## Support and contact details

For any issues or have questions, ideas or concerns.  Contact me at vmartinez72@live.com

## Technologies Used

* HTML, CSS, C#.


### License

Copyright (c) 2016 **Victoria Martinez**
