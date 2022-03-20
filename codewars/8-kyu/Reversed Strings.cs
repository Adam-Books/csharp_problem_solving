/*
Title:
  Reversed Strings
  
Description:
  Complete the solution so that it reverses the string passed into it.

  'world'  =>  'dlrow'
  'word'   =>  'drow'
  
Link:
  https://www.codewars.com/kata/5168bb5dfe9a00b126000018
  
*/

// Solutions:

// Solution 1:
using System;
public static class Kata
{
  public static string Solution(string s) 
  {
    char[] c = s.ToCharArray();
    Array.Reverse(c);
    return new String(c);
  }
}

// Solution 2:
using System;
using System.Linq;

public static class Kata
{
  public static string Solution(string str) 
  {
     return new string(str.ToArray().Reverse().ToArray());
  }
}

// Solution 3:
using System;
using System.Linq;
public static class Kata
{
  public static string Solution(string str) 
  {
    return string.Concat(str.Reverse());
  }
}

// Solution 4:
using System;
using System.Linq;
public static class Kata
{
  public static string Solution(string str) 
  {
    return string.Concat(str.Reverse());
  }
}

// Solution 5:
using System.Linq;

class Kata
{
  public static string Solution(string s) => string.Concat(s.Reverse());
}





