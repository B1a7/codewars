// Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

// Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}


using System.Collections.Generic;
using System.Collections;
public class Kata
{
         public static int[] MoveZeroes(int[] arr)
        {
            int count = 0;
            ArrayList arrayList = new ArrayList();
            for (int i=0; i< arr.Length; i++)
            { 
               
                 if (arr[i] !=0)
                {
                    arrayList.Add(arr[i]);
                }
                else
                {
                    count ++;
                }
            }
            for (int i = 0; i < count; i++)
            {
                arrayList.Add(0);
            }

            return (int[])arrayList.ToArray(typeof(int));
        }
}