using System;
using System.Collections.Generic;

namespace MorseCodeConverterProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var morseCode = new Dictionary<string, string>(){
                {"a",".-"},
                {"b","-..."},
                {"c","-.-."},
                {"d","-.."},
                {"e","."},
                {"f","..-."},
                {"g","--."},
                {"h","...."},
                {"i",".."},
                {"j",".---"},
                {"k","-.-"},
                {"l",".-.."},
                {"m","--"},
                {"n","-."},
                {"o","---"},
                {"p",".--."},
                {"q","--.-"},
                {"r",".-."},
                {"s","..."},
                {"t","-"},
                {"u","..-"},
                {"v","...-"},
                {"w",".--"},
                {"x","-..-"},
                {"y","-.--"},
                {"z","--.."},
                {"1",".----"},
                {"2","..---"},
                {"3","...--"},
                {"4","....-"},
                {"5","....."},
                {"6","-...."},
                {"7","--..."},
                {"8","---.."},
                {"9","----."},
                {"0","-----"},
                {" "," "},
                {".",".-.-.-"},
                {",","--..--"},
                {"?","..--.."},
                {";","-.-.-."},
                {":","---..."},
                {"-","-....-"},
                {"/","-..-."},
                {"'",".----."},
            };

            Console.WriteLine("Welcome to the Morse Code Translater!");
            Console.WriteLine("Each dot is one measure of time a dash is 3. Leave 3 measures between each letter and 7 measures between words.");
            Console.WriteLine("Type what you would like translated:");

            var untranslated = Console.ReadLine().ToLower();
            var translated = new List<string>();

            foreach (char c in untranslated)
            {
                translated.Add(morseCode[$"{c}"]);
            }

            foreach (string letter in translated)
            {
                Console.WriteLine($"{letter}");
            }
        }
    }
}
