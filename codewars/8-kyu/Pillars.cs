/*
Title:
  Pillars
  
Description:
  There are pillars near the road. The distance between the pillars is the same and the width of the pillars is the same. Your function accepts three arguments:

number of pillars (≥ 1);
distance between pillars (10 - 30 meters);
width of the pillar (10 - 50 centimeters).
Calculate the distance between the first and the last pillar in centimeters (without the width of the first and last pillar).
  
  
Link:
  https://www.codewars.com/kata/5bb0c58f484fcd170700063d
  
  
*/

// Solutions:
// Solution 1:
class Kata
{
 public static int Pillars(int numPill, int dist, int width) => 
   numPill == 1 ? 0 : ((numPill - 2) * width) + (((numPill - 1) * dist) * 100);
}

// Solution 2:
public static class Kata
{
 public static int Pillars(int a, int b, int c) => a is 1 ? 0 : 100 * b * --a + c * --a;
}

// Solution 3:
using System;

public static class Kata
{
    public static int Pillars(int numPill, int dist, int width)
    {
        return Math.Max(--numPill * (100 * dist + width) - width, 0);
    }
}

// Solution 4:







