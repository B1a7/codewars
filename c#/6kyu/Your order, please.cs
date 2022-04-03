// Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

// Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

// If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

// Examples
// "is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
// "4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
// ""  -->  ""




using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
public static class Kata
{
        public static string Order(string words)
        {
            if (string.IsNullOrWhiteSpace(words))
            {
                return "";
            }
            Dictionary<string, int> dic = new Dictionary<string, int>();

            string[] singleWord = words.Split();
            foreach (var word in singleWord)
            {
                foreach (var c in word.ToCharArray())
                {
                    if (char.IsDigit(c))
                    {
                        dic.Add(word, c);
                    }
                }
            }
            return string.Join(" ", dic.OrderBy(x => x.Value).Select(x => x.Key).ToList()) ;

        }
}