// You are given an array (which will have a length of at least 3, but could be very large) containing integers. The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. Write a method that takes the array as an argument and returns this "outlier" N.

// Examples
// [2, 4, 0, 100, 4, 11, 2602, 36]
// Should return: 11 (the only odd number)

// [160, 3, 1719, 19, 11, 13, -21]
// Should return: 160 (the only even number)



using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {            int odd =0;
            int oddValue = 0;
            int even =0;
            int evenValue = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 ==0)
                {
                    even++;
                    evenValue = integers[i];
                }
                else
                {
                    odd ++;
                    oddValue = integers[i];
                }

                if (even >1 && odd == 1)
                    return oddValue;
               
                else if (even ==1 && odd > 1)
                    return evenValue;
                
            }
            return 0;
  }
}