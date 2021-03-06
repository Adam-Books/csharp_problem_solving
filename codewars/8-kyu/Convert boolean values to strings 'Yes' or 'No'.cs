/*
Title:
  Convert boolean values to strings 'Yes' or 'No'.
  
Description:
  Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.

Link:
  https://www.codewars.com/kata/53369039d7ab3ac506000467
  
*/

// Solutions:

// Solution 1:
static class Kata
{
  public static string boolToWord(bool w) => (bool)w ? "Yes" : "No";
}

// Solution 2:
static class Kata
{
  public static string boolToWord(bool w) => w ? "Yes" : "No";
}

// Solution 3:
using System;
using System.Linq;

public static class Kata
{
  public static string boolToWord(bool word) => word==true ? "Yes" : "No";
}

// Solution 4:
using System;
using System.Linq;

public static class Kata
{
        public static string boolToWord(bool word) => word switch
        {
            true => "Yes",
            false => "No"
        };
}


