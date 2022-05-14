/*
Title:
  Remove First and Last Character
  
Description:
  It's pretty straightforward. 
  Your goal is to create a function that removes the first and last characters of a string. 
  You're given one parameter, the original string. 
  You don't have to worry with strings with less than two characters.

Link:
  https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0
  
*/

// Solutions:

// Solution 1:
class Kata
{
    public static string Remove_char(string s) => s.Substring(1, s.Length - 2);
}

// Solution 2:
public class Kata
{
  public static string Remove_char(string s) => s[1..^1];
}

// Solution 3:
using System.Text.RegularExpressions;

class Kata
{
  public static string Remove_char(string s) => Regex.Replace(s, "^.|.$", "");
}

// Solution 4:
using System;

public class Kata
{
    public static string Remove_char(string s)
    {
        // use s.Length - 2 because we have been removed the first charactor 
        // but length is not change
        return s.Remove(0, 1).Remove(s.Length - 2);
    }
}
