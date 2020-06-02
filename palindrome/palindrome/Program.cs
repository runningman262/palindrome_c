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
        static string userPhraseReversed;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or phrase to test if it is a palindrome.");
            //string userPhrase = Console.ReadLine().ToLower();
            string userPhrase = Regex.Replace(Console.ReadLine().ToLower(), @"\s", "");
            ReversePhrase(userPhrase);
            CheckPalindrome(userPhrase, userPhraseReversed);
        }

        static void ReversePhrase(string phraseToReverse)
        {
            int phraseLength = phraseToReverse.Length;
            userPhraseReversed = "";
            while (phraseLength > 0)
            {
                phraseLength--;
                userPhraseReversed = userPhraseReversed + phraseToReverse.Substring(phraseLength, 1);
            }
        }

        static void CheckPalindrome(string phrase1, string phrase2)
        {
            string result = (phrase1 == phrase2) ? "Palindrome!" : "Not a palindrome!";
            Console.WriteLine(result);
        }
    }
}
