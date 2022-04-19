/*
Title:
  String repeat

Description:
  Write a function called repeatStr which repeats the given string string exactly n times.

  repeatStr(6, "I") // "IIIIII"
  repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"
  
Link:
  https://www.codewars.com/kata/57a0e5c372292dd76d000d7e

*/

// Solutions:

// Solution 1:
namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s) 
    {
      string result = s;

      if (n != 0)
        {
          for (int i = 0; i < n - 1; i++) result += s;
        }
      else result = string.Empty;

       return result;
    }
  }
}

// Solution 2:





