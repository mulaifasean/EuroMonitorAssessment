using System;

namespace GetRequiredNumber
{
  public class GetRequiredNumber
  {
    public static int GetDifference(int inputNumber)
    {
     
      int maxNumber = 5;
      int requiredNumber = 0;

      try
      {
       
        if ((inputNumber >= 0) && (inputNumber < 5))
        {
          requiredNumber = maxNumber - inputNumber;
          Console.Write("The required number to make 5  is : " + " " + requiredNumber);
        }
        else
        {
          Console.Write("Error : input number should be less than 5");
        }
        
      }
      catch (FormatException fe)
      {

        Console.Write(fe.Message+"Error Only integer values can be passed!");
      }
      return requiredNumber;
     
    }
  }
}
