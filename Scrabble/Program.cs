using System;
using System.Collections.Generic;
using Scrabble.Models;

class Program
{

  public static Score myScore;

  static void Main()
  {
    myScore = new Score();
    Console.WriteLine("Enter a word to be scrabble scored.");
    string myWord = Console.ReadLine();
    myScore.GetWord(myWord);
    myScore.GetPoints();
    Console.WriteLine("Here is how many points your word is worth.");
    Console.WriteLine(myScore.Points);
  }
}