/*
Title:
  Name on billboard
  
Description:
  You can print your name on a billboard ad. Find out how much it will cost you. 
  Each letter has a default price of £30, but that can be different if you are given 2 parameters instead of 1.

  You can not use multiplier "*" operator.

  If your name would be Jeong-Ho Aristotelis, ad would cost £600. 20 leters * 30 = 600 (Space counts as a letter).
  
Link:
https://www.codewars.com/kata/570e8ec4127ad143660001fd
  
*/



// Solutions:

// Solution 1:
class Kata {
  public static double Billboard(string s, double price = 30) {
        double n = 0;
        for (int i = 0; i < s.Length; i++) n += price;
        return n;
  }
}
