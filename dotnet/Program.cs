// See https://aka.ms/new-console-template for more information
using dotnet;

Console.WriteLine("Hello, World!");


Console.WriteLine(Environment.NewLine);
Console.WriteLine("Please enter a number in.");
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

int result = SumOfDigitsOfNumber.Start(value);

Console.WriteLine("The result of the sum is: {0}", result);

Console.ReadLine();