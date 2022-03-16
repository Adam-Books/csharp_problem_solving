/*
Title:
  Convert a Number to a String!
  
Description:
  We need a function that can transform a number into a string.

  What ways of achieving this do you know?

  Examples:
  123 --> "123"
  999 --> "999"
  
Link:
  https://www.codewars.com/kata/5265326f5fda8eb1160004c8
  
*/

// Solutions:

// Solution 1:
class Kata
{
  public static string NumberToString(int n) => n + "";
}

// Solution 2:
using System;

public class Kata
{
  public static string NumberToString(int num)
  {
    return $"{num}";
  }
}

// Solution 3:
public class Kata
{
  public static string NumberToString(int num)
  {
    return num.ToString();
  }
}







