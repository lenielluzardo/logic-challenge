///<summary> 
/// Sum of Digits of a Number:
/// Given a number N, find the sum of its digits.
/// 
/// Example:
///   Input: n = 687
///   Output: 21
///   Explanation: The sum of its difits are: 6 + 8 + 7 = 21
///</summary>


using System;

namespace challenge.easy;

public static class SumOfDigitsOfNumber
{
  public static void Start()
  {
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
      Console.WriteLine
      (@"
        You need to provide a number.
        Try again.
      ");
    }

    int value = int.Parse(input);
    int result = SumOfDigits(value);

    Console.WriteLine("The result of the sum is: {0}", result);
    
  }

  private static int SumOfDigits(int n)
  {
    int sum = 0;
    while (n != 0)
    {
      // Extract the last digit
      int last = n % 10;

      // Add last digit to sum
      sum += last;

      // Remoce the last digit
      n /= 10;
    }

    return sum;
  }
}
