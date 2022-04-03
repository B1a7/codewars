// Write a function that takes a string of parentheses, and determines if the order of the parentheses is valid. The function should return true if the string is valid, and false if it's invalid.

// Examples
// "()"              =>  true
// ")(()))"          =>  false
// "("               =>  false
// "(())((()())())"  =>  true
// Constraints
// 0 <= input.length <= 100

// Along with opening (() and closing ()) parenthesis, input may contain any valid ASCII characters. Furthermore, the input string may be empty and/or not contain any parentheses at all. Do not treat other forms of brackets as parentheses (e.g. [], {}, <>).

using System.Linq;
using System;
using System.Collections.Generic;
using System.Collections;
public class Parentheses
{
          public static bool ValidParentheses(string input)
        {
            Stack<char> bracket = new Stack<char>();
            Dictionary<char, char> bracketsPairs = new Dictionary<char, char>()
            {
                { '(' , ')' },
                { '{' , '}' },
                { '[' , ']' },
                { '<' , '>' },
            };
            try
            {
                foreach (var item in input)
                {
                    if (bracketsPairs.Keys.Contains(item))
                    {
                        bracket.Push(item);
                    }
                    else if (bracketsPairs.Values.Contains(item))
                    {
                        if (item == bracketsPairs[bracket.First()])
                        {
                            bracket.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                        continue;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return bracket.Count() == 0 ? true : false;

        }
    
}