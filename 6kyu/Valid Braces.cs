/*
Write a function that takes a string of braces, and determines if the order of the braces is valid. It should return true if the string is valid, and false if it's invalid.

This Kata is similar to the Valid Parentheses Kata, but introduces new characters: brackets [], and curly braces {}. Thanks to @arnedag for the idea!

All input strings will be nonempty, and will only consist of parentheses, brackets and curly braces: ()[]{}.

What is considered Valid?
A string of braces is considered valid if all braces are matched with the correct brace.

Examples
"(){}[]"   =>  True
"([{}])"   =>  True
"(}"       =>  False
"[(])"     =>  False
"[({})](]" =>  False
*/

using System;
using System.Linq;
using System.Collections.Generic;

public class Brace {

        public static bool validBraces(String braces)
        {
            Stack<char> bracket = new Stack<char>();
            Dictionary<char, char> bracketsPairs = new Dictionary<char, char>()
            {
                { '[' , ']' },
                { '<' , '>' },
                { '(' , ')' },
                { '{' , '}' },
            };

            try
            {
                foreach (char c in braces)
                {
                    if (bracketsPairs.Keys.Contains(c))
                        bracket.Push(c);
                    else if (bracketsPairs.Values.Contains(c))
                    {
                        if (c == bracketsPairs[bracket.First()])
                            bracket.Pop();    
                        else
                            return false;
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }
            if (bracket.Count() == 0)
                return true;
            else
                return false;
        }
}