/*
Title:
  Name on billboard
  
Description:
  
  
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
