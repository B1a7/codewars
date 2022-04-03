// Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).

// Examples
// "the-stealth-warrior" gets converted to "theStealthWarrior"
// "The_Stealth_Warrior" gets converted to "TheStealthWarrior"

using System;
using System.Text;
public class Kata
{
  public static string ToCamelCase(string str)
  {
                StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '_' || str[i] =='-')
                {
                    sb.Append(str[i+1].ToString().ToUpper());
                    i++;
                }
                else
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
  }
}