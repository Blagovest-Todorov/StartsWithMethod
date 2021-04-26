using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Aword";

            char startsWithLetter = char.Parse(Console.ReadLine());

            if (word.StartsWith(startsWithLetter))
            {
                Console.WriteLine($"{word} starts with letter {startsWithLetter}");
            }
            else
            {
                Console.WriteLine($"{word},  does not start with {startsWithLetter} letter");
            }  
            // StartsWith() Method returns bool value -> true if found a match, else return false
               // StartsWith() is a string Method checks wheather the beginning of curr string instance
               //matches with a specified string, char or not
        }
    }
}
