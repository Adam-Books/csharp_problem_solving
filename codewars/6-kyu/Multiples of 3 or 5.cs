/*
Title:
  Multiples of 3 or 5
  
Description:
  If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
  The sum of these multiples is 23.

  Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. 
  Additionally, if the number is negative, return 0 (for languages that do have them).

  Note: If the number is a multiple of both 3 and 5, only count it once.

  Courtesy of projecteuler.net (Problem 1)
  
Link:
  https://www.codewars.com/kata/514b92a657cdc65150000006
  
  */
  
// Solutions:
// Solution 1:
public static class Kata
{
  public static int Solution(int value)
  {
    int r = 0;
    for (int i = 0; i < value; i++) 
    {
      if (i % 3 == 0 || i % 5 == 0) r += i;
    }
    return r;
  }
}

// Solution 2:
using System.Linq;
public static class Kata
{
  public static int Solution(int n)
  {
   return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
  }
}

// Solution 3:
public static class Kata
{
  public static int Solution(int value)
  {
    int sum = 0;
    for(int i = 0; i < value; i++) {
       sum += ((i % 3 == 0 || i % 5 == 0) ? i : 0);
    }
    return sum;
  }
}

  
  
  
  
  
