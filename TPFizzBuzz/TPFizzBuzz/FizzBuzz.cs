using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace TPFizzBuzz
{
    public class FizzBuzz
    {
        private static readonly string KEY_WORD = "fizzbuzz";

        private Dictionary<string, int> divisors;
        /*
        private static readonly Dictionary<string, int> WORD_DIVISORS = new Dictionary<string, int>
            {
                {"Fizz", 3},
                {"Buzz", 5}
            };
        */

        private void setDivisorFromString(string divisorString )
        {
            String[] divisors = divisorString.Split(",");
            
            this.divisors = new Dictionary<string, int>
            {
                {"Fizz", int.Parse(divisors[0])},
                {"Buzz", int.Parse(divisors[1])}
            };
        }
        public void handleSentence(string sentence)
        {
            int number = this.parseSentence(sentence);
            this.printSentence(number);
        }
        
        
        private int parseSentence(string sentence)
        {
            string[] splitSentence = sentence.Split(" ");
            
            if (splitSentence.Length != 3 && splitSentence[0] == KEY_WORD)
            {
                throw new Exception("Please specify a value to fizbuzz");
            }
            
            this.setDivisorFromString(splitSentence[1]);
            return int.Parse(splitSentence[2]);
        }

        
        private void checkNumber(int number)
        {
            if (number < 0) {
                throw new Exception("Cannot fizzbuzz negative numbers");
            }

            if (number > 100)
            {
                throw new Exception("Cannot fizzbuzz negative numbers greater than 100");

            }
            
        }

        private void printSingleNumber(int number)
        {
            foreach (KeyValuePair<string, int> wordItem in this.divisors)
            {
                if (number % wordItem.Value == 0)
                {
                    Console.Write(wordItem.Key + " ");
                    return;
                }
            }
            Console.Write(number + " ");
        }
        
        private void printSentence(int number)
        {
            this.checkNumber(number);
            for (int i = 1; i <= number; i++)
            {
                this.printSingleNumber(i);
            }
        }
        
        
    }
}