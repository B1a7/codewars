// Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

// Examples
// Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
// Kata.PigIt("Hello world !");     // elloHay orldway !

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Kata
{
                public static string PigIt(string str)
        {
            StringBuilder sb = new StringBuilder();
            string[] stringChars = str.Split(' ');
            foreach (var item in stringChars)
            {    
                sb.Append(item.Remove(0,1));
                sb.Append(item[0]);
                if (item.ToCharArray().Count() != 1)
                {
                    sb.Append("ay");
                    sb.Append(' ');
                }
                
            }
            
            return sb.ToString().TrimEnd();
        }
}