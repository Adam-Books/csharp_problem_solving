/*
Title:
  CamelCase
  
Description:
  There is a sequence of words in CamelCase as a string of letters, , having the following properties:

  It is a concatenation of one or more words consisting of English letters.
  All letters in the first word are lowercase.
  For each of the subsequent words, the first letter is uppercase and rest of the letters are lowercase.
  Given , determine the number of words in .

  Example

  There are  words in the string: 'one', 'Two', 'Three'.

  Function Description

  Complete the camelcase function in the editor below.

  camelcase has the following parameter(s):

  string s: the string to analyze
  Returns

  int: the number of words in 
  Input Format

  A single line containing string .

  Constraints

  Sample Input

  saveChangesInTheEditor
  Sample Output

  5
  Explanation

  String  contains five words:

  save
  Changes
  In
  The
  Editor
  Need help? Try this problem first to get familiar with HackerRank environment.
  
Link:
  https://www.hackerrank.com/challenges/camelcase/problem?isFullScreen=true
  
*/

// Solutions:

// Solution 1:
public static int camelcase(string s) =>
    s.ToCharArray().Where(c => Char.IsUpper(c)).Count() + 1;

// Solution 2:
public static int camelcase(string s) =>
    s.Count(char.IsUpper) + 1;

// Solution 3:









