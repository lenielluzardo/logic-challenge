/// Print Multiplication Table of a Number:
/// Given a number N, print its mutiplication table.
/// Input:  5
/// Output: 
/// 5 * 1 = 5
/// 5 * 2 = 10
/// 5 * 3 = 15
/// 5 * 4 = 20 
/// ...rest 

using System;
using System.Text;

namespace challenge.easy;

public static class PrintMultiplicationTable
{
  public static void Start()
  {
    Console.WriteLine("* Print Multiplication Table Challenge *");
    Console.WriteLine("Please enter a number:");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
      Console.WriteLine("You must provide a value");
      Console.WriteLine("You must provide a value, restart the app.");
      return;
    }

    int value = int.Parse(input);

    string result = BuildMultipllicationTable(value);
    Console.WriteLine(result);

  }

  private static string BuildMultipllicationTable(int value)
  {
    StringBuilder builder = new StringBuilder();

    for (int i = 1; i <= 10; i++)
    {
      string row = $"{value} x {i} = {value * i}";
      builder.AppendLine(row);
    }

    return builder.ToString();
  }
}
