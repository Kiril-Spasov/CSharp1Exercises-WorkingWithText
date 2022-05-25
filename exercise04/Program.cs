using System;

namespace exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words separated by space: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }
            Console.WriteLine(variableName);
        }
    }
}
