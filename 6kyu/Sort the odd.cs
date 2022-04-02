/*
ask
You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.

Examples
[7, 1]  =>  [1, 7]
[5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
[9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]
*/


using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] SortArray(int[] array)
  {
      var queue = new Queue<int>(array.Where(i => i % 2 == 1).OrderBy(i => i));

      return array.Select( i => i % 2 == 1 ? queue.Dequeue() : i).ToArray();
  }
}