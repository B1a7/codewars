// Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

// Example
// Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
// The returned format must be correct in order to complete this challenge.
// Don't forget the space after the closing parentheses!

using System.Text;
public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
                StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    sb.Append('(');
                }
                    

                if (i == 3)
                {
                    sb.Append(')');
                    sb.Append(' ');
                }
                if (i == 6)
                {
                    sb.Append('-');
                }
                sb.Append(numbers[i]);
            }
            string result = sb.ToString();
            return result;
  }
}