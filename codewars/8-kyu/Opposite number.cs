/*
Title:
  Opposite number

Description:
  Very simple, given an integer or a floating-point number, find its opposite.

  Examples:

  1: -1
  14: -14
  -34: 34

Link:
  https://www.codewars.com/kata/56dec885c54a926dcd001095

*/

// Solutions:

// Solution 1:
public class Kata
    {
        public static int Opposite(int n) => -n;
    }

// Solution 2:
using System;

public class Kata
    {
        public  static int Opposite(int number)
        {
           if (number < 0) number = Math.Abs(number);
           else number = number - number - number;
           return number;    
        }
    }







