/*
Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

array = [[1,2,3],
         [4,5,6],
         [7,8,9]]
snail(array) #=> [1,2,3,6,9,8,7,4,5]
For better understanding, please follow the numbers of the next array consecutively:

array = [[1,2,3],
         [8,9,4],
         [7,6,5]]
snail(array) #=> [1,2,3,4,5,6,7,8,9]
This image will illustrate things more clearly:


NOTE: The idea is not sort the elements from the lowest value to the highest; the idea is to traverse the 2-d array in a clockwise snailshell pattern.

NOTE 2: The 0x0 (empty matrix) is represented as en empty array inside an array [[]].
*/


using System.Collections.Generic;

public class SnailSolution
{
        public static int[] Snail(int[][] array)
        {
                         //int[] result = new int[array.Length*array.Length];
                List<int> list = new List<int>();
                if (array.Length == 1)
                    return array[0];

                //int limes = 0;
                //column int moves vertically
                //row int moves horizontally
                int columnStart = 0;
                int rowEnd = array.Length - 1;
                int columnEnd = array.Length - 1;
                int rowStart = 0;

                for (int i = 0; i < array.Length / 2; i++)
                {
                    for (int row = rowStart; row <= rowEnd; row++)
                    {
                        list.Add(array[columnStart][row]);
                    }
                    columnStart++;

                    for (int column = columnStart; column <= columnEnd; column++)
                    {
                        list.Add(array[column][rowEnd]);
                    }
                    rowEnd--;

                    for (int row = rowEnd; row >= rowStart; row--)
                    {
                        list.Add(array[columnEnd][row]);
                    }
                    columnEnd--;
                    for (int column = columnEnd; column >= columnStart; column--)
                    {
                        list.Add(array[column][rowStart]);
                    }
                    rowStart++;
                }


                if (array.Length % 2 != 0)
                {
                    list.Add(array[rowStart][columnStart]);
                }
                return list.ToArray(); 
        }

}