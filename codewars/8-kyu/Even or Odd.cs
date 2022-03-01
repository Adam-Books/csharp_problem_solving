/*
Title:
  Even or Odd
  
Description:
  Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

Link:
  https://www.codewars.com/kata/53da3dbb4a5168369a0000fe

*/

// Solutions:
// Solution 1:
namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number) => number % 2 == 0 ? "Even" : "Odd";
  }
}

// Solution 2:
using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
      return (number % 2 != 0) ? "Odd" : "Even";
    }
  }
}

// Solution 3:
using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number) => number % 2 > 0 ? "Odd" : "Even";
  }
}



