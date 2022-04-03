// Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

// Examples: spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" spinWords( "This is a test") => returns "This is a test" spinWords( "This is another test" )=> returns "This is rehtona test"

using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
public class Kata
{
        public static string SpinWords(string sentence)
        {
            StringBuilder sb = new StringBuilder();
            string[] arraySenstence = sentence.Split(' ');
            foreach (var item in arraySenstence)
            {
                var charItem = item.ToCharArray();
                Array.Reverse(charItem);
                
                if (item.Length >= 5)
                 sb.Append(charItem);                            
                else
                    sb.Append(item);
                sb.Append(' ');
            }
            return sb.ToString().TrimEnd();
        }
}