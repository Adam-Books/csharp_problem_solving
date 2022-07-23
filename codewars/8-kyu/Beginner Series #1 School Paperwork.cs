/*
Title:
  Beginner Series #1 School Paperwork
  
Description:
  Your classmates asked you to copy some paperwork for them. You know that there are 'n' classmates and the paperwork has 'm' pages.

Your task is to calculate how many blank pages do you need. If n < 0 or m < 0 return 0.

Example:
n= 5, m=5: 25
n=-5, m=5:  0

  
Link:
  https://www.codewars.com/kata/55f9b48403f6b87a7c0000bd

  
*/

// Solutions:

// Solution 1:
static class Paper
  {
    public static int Paperwork(int n, int m) => m < 0 || n < 0 ? 0 : m * n;
  }

// Solution 2:







