/// Sum of Digits of a Number:
/// Given a number N, find the sum of its digits.
/// 
/// Example:
///   Input: n = 687
///   Output: 21
///   Explanation: The sum of its difits are: 6 + 8 + 7 = 21
/// 


using System;

namespace challenge.easy;

public static class SumOfDigitsOfNumber
{
  public static int Start(int value)
  {
    return SumOfDigits(value);
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
