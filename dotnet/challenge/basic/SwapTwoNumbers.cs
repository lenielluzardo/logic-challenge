/**
Swap Two Numbers:
Given two numbers A and B, the task is to swap them.

Example:
Input: a = 2, b = 3
Output: a = 3, b = 2
*/

using System;

namespace challenge.basic;

public class SwapTwoNumbers: Challenge
{
  public SwapTwoNumbers():base()
  {
      
  }

  


  // public static void Start()
  // {
  //   Console.WriteLine("Swap Two Numbers: Given two numbers A and B, the task is to swap them.");
  //   Console.WriteLine("Provide number A =");
  //   string[] input = new string[2];

  //   // TODO: Implement for loop for reading, validation and parsing of 4input A & B.
  //   input[0] = Console.ReadLine();
  //   if (string.IsNullOrWhiteSpace(input[0]))
  //   {
  //     Console.WriteLine("You must provide a number, please restart the application.");
  //     return;
  //   }

  //   Console.WriteLine("Provide number B =");
  //   input[1] = Console.ReadLine();
  //   if (string.IsNullOrWhiteSpace(input[1]))
  //   {
  //     Console.WriteLine("You must provide a number, please restart the application.");
  //     return;
  //   }

  //   var result = SwapNumbers(int.Parse(input[0]), int.Parse(input[1]));
  //   Console.WriteLine($"Numbers were swapped. Input A = {result[0]} and Input B = {result[1]}");
  // }

  private static int[] SwapNumbers(int inputA, int inputB)
  {
    int[] swaped = [inputB, inputA];
    return swaped;
  }
}
