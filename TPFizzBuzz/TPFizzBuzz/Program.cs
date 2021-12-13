using System;

namespace TPFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            FizzBuzz fizbuzz = new FizzBuzz();
            fizbuzz.handleSentence(sentence);
        }
    }
}