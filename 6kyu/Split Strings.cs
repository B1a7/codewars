/*
Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

Examples:

* 'abc' =>  ['ab', 'c_']
* 'abcdef' => ['ab', 'cd', 'ef']

*/


using System;
using System.Collections.Generic;

public class SplitString
{
        public static string[] Solution(string str)
        {
            if (str.Length % 2 != 0)
                str += "_";

            List<string> list = new List<string>();
            for (int i = 0; i < str.Length; i += 2)
            {
                list.Add(str[i].ToString() + str[i + 1].ToString());
            }
            return list.ToArray();
        }
}
