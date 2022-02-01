/*
Title:
  Vowel Count
  
Description:
  Return the number (count) of vowels in the given string.

We will consider a, e, i, o, u as vowels for this Kata (but not y).

The input string will only consist of lower case letters and/or spaces.

Link:
  https://www.codewars.com/kata/54ff3102c1bad923760001f3

*/

// Solutions:
// Solution 1:
using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str) => 
      str.Count(c => "aeiou".Contains(Char.ToLower(c)));
}

// Solution 2:
using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str) => 
      str.Count(c => "aeiou".Contains(c));
}

// Solution 3:
using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str) => 
      str.Count(c=> "aeiou".IndexOf(c) != -1);
}

// Solution 4:
using System;
using System.Text.RegularExpressions;

public static class Kata
{
    public static int GetVowelCount(string str) => 
      (Regex.Matches(str, @"[aeiouAEIOU]")).Count;
}

// Solution 5:
using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        string vowels = "aeiou";
        
        foreach (char letter in str)
        {
          if (vowels.IndexOf(letter) != -1)
            vowelCount++;
        }

        return vowelCount;
    }
}

// Solution 6:
using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        for (int i = 0; i < str.Length; i++)
         if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
          vowelCount++;

        return vowelCount;
    }
}





