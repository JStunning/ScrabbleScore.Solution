using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Score
  {
    public int Points { get; set; }
    public string Word { get; set; }
    public string[] onePoint = {"a", "e", "i", "o", "u", "l", "n", "r", "s", "t"};
    public string[] twoPoint = {"d", "g"};
    public string[] threePoint = {"b", "c", "m", "p"};
    public string[] fourPoint = {"f", "h", "v", "w", "y"};
    public string[] fivePoint = {"k"};
    public string[] eightPoint = {"j", "x"};
    public string[] tenPoint = {"q", "z"};

    public Score()
    {
      Points = 0;
      Word = "";
    }

    public void GetWord(string word)
    {
      Word = word.ToLower();
    }

    public void Get1Points()
    {
      char[] charArr = Word.ToCharArray();
      for(int i = 0; i < charArr.Length; i++)
      {
        for(int j = 0; j < onePoint.Length; j++)
        {
          // compare word[i] to pointsArrays;
          if (charArr[i].ToString() == onePoint[j])
          {
            Points++;
          }
        }
      }
    }

    public void Get2Points()
    {
      char[] charArr = Word.ToCharArray();
      for(int i = 0; i < charArr.Length; i++)
      {
        for(int j = 0; j < twoPoint.Length; j++)
        {
          // compare word[i] to pointsArrays;
          if (charArr[i].ToString() == twoPoint[j])
          {
            Points += 2;
          }
        }
      }
    }

    public void Get3Points()
    {
      char[] charArr = Word.ToCharArray();
      for(int i = 0; i < charArr.Length; i++)
      {
        for(int j = 0; j < threePoint.Length; j++)
        {
          // compare word[i] to pointsArrays;
          if (charArr[i].ToString() == threePoint[j])
          {
            Points += 3;
          }
        }
      }
    }

    public void Get4Points()
    {
      char[] charArr = Word.ToCharArray();
      for(int i = 0; i < charArr.Length; i++)
      {
        for(int j = 0; j < fourPoint.Length; j++)
        {
          // compare word[i] to pointsArrays;
          if (charArr[i].ToString() == fourPoint[j])
          {
            Points += 4;
          }
        }
      }
    }

    public void Get5Points()
    {
      char[] charArr = Word.ToCharArray();
      for(int i = 0; i < charArr.Length; i++)
      {
        for(int j = 0; j < fivePoint.Length; j++)
        {
          // compare word[i] to pointsArrays;
          if (charArr[i].ToString() == fivePoint[j])
          {
            Points += 5;
          }
        }
      }
    }

    public void Get8Points()
    {
      char[] charArr = Word.ToCharArray();
      for(int i = 0; i < charArr.Length; i++)
      {
        for(int j = 0; j < eightPoint.Length; j++)
        {
          // compare word[i] to pointsArrays;
          if (charArr[i].ToString() == eightPoint[j])
          {
            Points += 8;
          }
        }
      }
    }

    public void Get10Points()
    {
      char[] charArr = Word.ToCharArray();
      for(int i = 0; i < charArr.Length; i++)
      {
        for(int j = 0; j < tenPoint.Length; j++)
        {
          // compare word[i] to pointsArrays;
          if (charArr[i].ToString() == tenPoint[j])
          {
            Points += 10;
          }
        }
      }
    }

    public void GetPoints()
    {
      Get1Points();
      Get2Points();
      Get3Points();
      Get4Points();
      Get5Points();
      Get8Points();
      Get10Points();
    }

  }
}