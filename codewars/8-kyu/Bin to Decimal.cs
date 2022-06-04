/*
Title:
  Bin to Decimal

Description:
  Complete the function which converts a binary number (given as a string) to a decimal number.

Link:
  https://www.codewars.com/kata/57a5c31ce298a7e6b7000334

*/

// Solutions:

// Solution 1:
using System;

namespace Solution
{
  public static class Program
  {
    public static int binToDec(string s) => Convert.ToInt32(s, 2);
  }
}

// Solution 2:
using System;

namespace Solution
{
  public static class Program
  {
    public static int binToDec(string s)
    {
      int result = 0;
      var length = s.Length;
      foreach(char c in s)
      {
        length--;
        if(c == '1')
          result +=  (int)(Math.Pow(2,length));
      }
    
      return result;
    }
  }
}

// Solution 3:









