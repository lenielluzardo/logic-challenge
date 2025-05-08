/**
Sum of N Natural Numbers:
Given a number N, find the sum of the first N natural numbers.

Example:
Input: n = 3
Output: 6
Explanation: 1 + 2 + 3 = 6
*/

using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace challenge.basic;

public static class SumOfNNaturalNumbers
{
  public static void Start()
  {
    Console.WriteLine("Sum of Naturals of N:");
    string input = Console.ReadLine();
    int value = int.Parse(input);

    var result = SumNaturalNumbers(value);
    Console.WriteLine($"Naturals of {value} are: {result.ToString()}");
  }
  
  private static string SumNaturalNumbers(int n)
  {
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
      sum += i;
    }
    return $"{sum}";
  }
}
