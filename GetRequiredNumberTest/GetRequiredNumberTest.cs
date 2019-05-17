using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetRequiredNumberTest
{
  [TestClass]
  public class GetRequiredNumberTest
  {
    [TestMethod]
    public void Test_RequiredNumberPass()
    {
      //Arrange
      int inputNumber = 3;
      int expectedRequiredNumber = 2;

      //Act
      int actualNumber = GetRequiredNumber.GetRequiredNumber.GetDifference(inputNumber);

      //Asset
      Assert.AreEqual(expectedRequiredNumber, actualNumber);
    }

    [TestMethod]
    public void Test_RequiredNumberFail()
    {
      //Arrange
      int inputNumber = 6;
      int expectedRequiredNumber = -1;

      //Act
      int actualNumber = GetRequiredNumber.GetRequiredNumber.GetDifference(inputNumber);

      //Asset
      Assert.AreNotEqual(expectedRequiredNumber, actualNumber);
    }

  }
}
