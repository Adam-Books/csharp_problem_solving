/*
Title:
  CamelCase
  
  
  
Link:
  https://www.hackerrank.com/challenges/camelcase/problem?isFullScreen=true
  
*/

// Solutions:

// Solution 1:
public static int camelcase(string s) =>
    s.ToCharArray().Where(c => Char.IsUpper(c)).Count() + 1;




