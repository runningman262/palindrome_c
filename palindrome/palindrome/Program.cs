using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or phrase to test if it is a palindrome.");
            //string userPhrase = Console.ReadLine().ToLower();
            string userPhrase = Regex.Replace(Console.ReadLine().ToLower(), @"\s", "");
            string userPhraseReversed = ReversePhrase(userPhrase);
            string palendromeResult = CheckPalindrome(userPhrase, userPhraseReversed);
            Console.WriteLine(palendromeResult);
        }

        static string ReversePhrase(string phraseToReverse)
        {
            int phraseLength = phraseToReverse.Length;
            string userPhraseReversed = "";
            while (phraseLength > 0)
            {
                phraseLength--;
                userPhraseReversed = userPhraseReversed + phraseToReverse.Substring(phraseLength, 1);
            }
            return userPhraseReversed;
        }

        static string CheckPalindrome(string phrase1, string phrase2)
        {
            string result = (phrase1 == phrase2) ? "Palindrome!" : "Not a palindrome!";
            return result;
        }
    }
}
