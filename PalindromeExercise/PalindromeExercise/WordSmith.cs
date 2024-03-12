using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            bool result = false;
            string revWord = string.Join("", word.ToCharArray().Reverse());
            /*
            string revWord = "";
            for (int c = word.Length - 1; c >= 0; c--)
            {
                revWord += word[c];
            }
            */
            if (word.ToLower() == revWord.ToLower())
            {
                result = true;
            };
            return result;
        }
    }
}
