using System;

namespace challenge;

public abstract class Challenge
{
  public static void Start(string challengeName)
  {
    Console.WriteLine($"Great!, you chose the {challengeName} challenge.");

    Solve();
  }

  protected static void Solve()
  {
    
  }

}
