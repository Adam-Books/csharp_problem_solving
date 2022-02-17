/*
Title:
  Simple Array Sum
  
Description:    
  Given an array of integers, find the sum of its elements.

  For example, if the array , , so return .

  Function Description

  Complete the simpleArraySum function in the editor below. 
  It must return the sum of the array elements as an integer.

  simpleArraySum has the following parameter(s):

  ar: an array of integers
  Input Format

  The first line contains an integer, , denoting the size of the array.
  The second line contains  space-separated integers representing the array's elements.

  Constraints


  Output Format

  Print the sum of the array's elements as a single integer.

  Sample Input

  6
  1 2 3 4 10 11
  Sample Output

  31
  Explanation

  We print the sum of the array's elements: .
  
Link:
  https://www.hackerrank.com/challenges/simple-array-sum/problem?isFullScreen=true

*/

// Solutions:

// Solution 1:
class Result
{

    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> ar)
    {
        int r = 0;
        foreach (int v in ar) r += v;
        return r;
    }

}



