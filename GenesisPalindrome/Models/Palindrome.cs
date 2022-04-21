﻿using System.Text.RegularExpressions;

namespace GenesisPalindrome.Models
{
    public class Palindrome
    {
        public bool isPalindrome;
        public string? UserWord { get; set; }
        public string? ReversedWord { get; set; }

        // reverses UserWord
        public string ReverseWord(string UserWord)
        {
            // create an empty string
            string reversedWord = "";

            // loop over user input starting at last index and 
            // finishing with index zero, each iteration "add"
            // char to string
            for (int i = UserWord.Length - 1; i >= 0; i--)
            {
                reversedWord += (UserWord[i].ToString());
            }

            return reversedWord;
        }

        public bool IsPalindrome(string UserWord)
        {
            // prepare string before reversing and checking
            // whether palindrome
            UserWord = StringPrep(UserWord);

            // reverse UserWord
            // string reversedWord = ReverseWord(UserWord).ToLower();
            string reversedWord = ReverseWord(UserWord);

            // loop over both UserWord and reversedWord and check
            // to see if char match
            for (int i = 0; i < UserWord.Length - 1; i++)
            {
                // if (UserWord.Equals(reversedWord))
                if(UserWord[i] == reversedWord[i])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

        // prepares the string to check for palindrome by removing
        // all non alphanumeric characters and changing to lowercase
        public string StringPrep(string UserWord)
        {
            // use regex to remove all non alphanumeric characters
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            UserWord = rgx.Replace(UserWord, "");
            UserWord = UserWord.ToLower();

            return UserWord;
        }
    }
}
