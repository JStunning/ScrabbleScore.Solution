using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void Score_ScoreConstructor_NewScore()
    {
      // Arrange
      Score newScore = new Score();
      // Act
      int result1 = newScore.Points;
      string result2 = newScore.Word;
      string result3 = newScore.onePoint[0];
      string result4 = newScore.twoPoint[0];
      string result5 = newScore.threePoint[0];
      string result6 = newScore.fourPoint[0];
      string result7 = newScore.fivePoint[0];
      string result8 = newScore.eightPoint[0];
      string result9 = newScore.tenPoint[0];
      // Assert
      Assert.AreEqual(result1, 0);
      Assert.AreEqual(result2, "");
      Assert.AreEqual(result3, "a");
      Assert.AreEqual(result4, "d");
      Assert.AreEqual(result5, "b");
      Assert.AreEqual(result6, "f");
      Assert.AreEqual(result7, "k");
      Assert.AreEqual(result8, "j");
      Assert.AreEqual(result9, "q");
    }

    [TestMethod]
    public void Score_GetWord_Hello()
    {
      // Arrange
      Score newScore = new Score();
      newScore.GetWord("Hello");
      // Act
      string result = newScore.Word;
      // Assert
      Assert.AreEqual(result, "hello");
    }

    // [TestMethod]
    // public void Score_GetPoints_1()
    // {
    //   // Arrange
    //   Score newScore = new Score();
    //   newScore.GetWord("A");
    //   newScore.GetPoints();
    //   // Act
    //   int result = newScore.Points;
    //   // Assert
    //   Assert.AreEqual(result, 0);
    // }

    // [TestMethod]
    // public void Score_GetPoints_2()
    // {
    //   // Arrange
    //   Score newScore = new Score();
    //   newScore.GetWord("D");
    //   newScore.GetPoints();
    //   // Act
    //   int result = newScore.Points;
    //   // Assert
    //   Assert.AreEqual(result, 2);
    // }

    // [TestMethod]
    // public void Score_GetPoints_3()
    // {
    //   // Arrange
    //   Score newScore = new Score();
    //   newScore.GetWord("B");
    //   newScore.GetPoints();
    //   // Act
    //   int result = newScore.Points;
    //   // Assert
    //   Assert.AreEqual(result, 3);
    // }

    // [TestMethod]
    // public void Score_GetPoints_4()
    // {
    //   // Arrange
    //   Score newScore = new Score();
    //   newScore.GetWord("f");
    //   newScore.GetPoints();
    //   // Act
    //   int result = newScore.Points;
    //   // Assert
    //   Assert.AreEqual(result, 4);
    // }

    // [TestMethod]
    // public void Score_GetPoints_5()
    // {
    //   // Arrange
    //   Score newScore = new Score();
    //   newScore.GetWord("K");
    //   newScore.GetPoints();
    //   // Act
    //   int result = newScore.Points;
    //   // Assert
    //   Assert.AreEqual(result, 5);
    // }

    // [TestMethod]
    // public void Score_GetPoints_8()
    // {
    //   // Arrange
    //   Score newScore = new Score();
    //   newScore.GetWord("j");
    //   newScore.GetPoints();
    //   // Act
    //   int result = newScore.Points;
    //   // Assert
    //   Assert.AreEqual(result, 8);
    // }

    // [TestMethod]
    // public void Score_GetPoints_10()
    // {
    //   // Arrange
    //   Score newScore = new Score();
    //   newScore.GetWord("q");
    //   newScore.GetPoints();
    //   // Act
    //   int result = newScore.Points;
    //   // Assert
    //   Assert.AreEqual(result, 10);
    // }

    [TestMethod]
    public void Score_GetPoints_33()
    {
      // Arrange
      Score newScore = new Score();
      newScore.GetWord("adbfkjq");
      newScore.GetPoints();
      // Act
      int result = newScore.Points;
      // Assert
      Assert.AreEqual(result, 33);
    }
  }
}