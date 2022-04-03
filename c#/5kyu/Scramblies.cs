/*
Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.

Notes:

Only lower case letters will be used (a-z). No punctuation or digits will be included.
Performance needs to be considered.
Examples
scramble('rkqodlw', 'world') ==> True
scramble('cedewaraaossoqqyt', 'codewars') ==> True
scramble('katas', 'steak') ==> False
*/

using System;
using System.Linq;

public class Scramblies 
{
    public static bool Scramble(string str1, string str2)
    {

            var s = str1.ToList();
    return str2.All(c => s.Remove(c));
    }
}