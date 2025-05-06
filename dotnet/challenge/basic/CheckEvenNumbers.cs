///<summary>
/// Check Even Numbers: 
/// Given a number N, check whether a given number is even or odd.
/// Return 'true' for even and 'false' for odd.
///  
/// Exmple:
///   Input: 2
///   Output: true
/// 
///   Input: 5
///   Output: false
///</summary>

using System;

namespace challenge.basic;

public static class CheckEvenNumbers
{
  public static void Start()
  {
    Console.WriteLine("Provide a number to check whether is even or odd.");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
      Console.WriteLine("You must provide a number. Restart the app.");
      return;
    }

    int value = int.Parse(input);

    string result = CheckEvenNumber(value);

    Console.WriteLine(result);
  }

  private static string CheckEvenNumber(int value)
  {
    bool isEven = value % 2 == 0;

    if (isEven)
    {
      return $"{value} is even number";
    }
    else
    {
      return $"{value} is odd number";
    }
  }
}
