using System;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            //convert all characters of value to lowercase
            value = value.ToLower();

            //replace all the characters in value that is not "aeiou" to ""
            string vowelString = Regex.Replace(value, @"[^aeiou+]", "");

            //return the length of the remaining string as the count of all the "AEIOU" in the string
            return vowelString.Length;
        }
    }
}
