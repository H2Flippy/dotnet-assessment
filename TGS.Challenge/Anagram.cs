using System.Text.RegularExpressions;

namespace TGS.Challenge
{

  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
        
        public bool AreAnagrams(string word1, string word2)
        {
            //convert all characters of word1 and word2 to lower
            word1 = word1.ToLower();
            word2 = word2.ToLower();

            //remove all spaces and punctuations contained in the word1 and word2 with regex
            word1 = Regex.Replace(word1, @"[^a-z+]", "");
            word2 = Regex.Replace(word2, @"[^a-z+]", "");

            //check if the two words or phrases have equal amount of characters if not they are not the two words can't be anagrams of each other
            if (word1.Length != word2.Length)
                return false;

            //loop through each character of word1 and find the index of the first occurance of the character in word2.
            foreach(char w1 in word1)
            {
                //get index of first occurance of the w1 character in word2
                int word2Index = word2.IndexOf(w1);

                // if word2Index == -1 the character in word1 one was not found in word2 and returns false
                if (word2Index != -1)
                {
                    //remove character at index in word2
                    word2 = word2.Remove(word2Index, 1);
                }
                else
                {
                    return false;
                }
            }

            // return false if there is a character left in word2
            if(word2.Length > 0)
            {
                return false;
            }

            return true;
        }

    }
}
