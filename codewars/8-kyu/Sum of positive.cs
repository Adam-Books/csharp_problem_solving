/*
Title:
  Sum of positive
  
Description:
  You get an array of numbers, return the sum of all of the positives ones.

  Example [1,-4,7,12] => 1 + 7 + 12 = 20

  Note: if there is nothing to sum, the sum is default to 0.
  
Link:
  https://www.codewars.com/kata/5715eaedb436cf5606000381    
  
*/

// Solutions:

// Solution 1:
class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int r = 0;
    foreach(int k in arr)
      {
        if (k > 0) r += k;
      }
    return r;
  }
}

// Solution 2:
using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    return arr.Where(x => x > 0).Sum();
  }
}


