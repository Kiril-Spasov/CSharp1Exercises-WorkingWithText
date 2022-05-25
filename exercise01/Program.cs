using System;
using System.Collections.Generic;

namespace exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements;

            Console.WriteLine("Enter a few numbers separated by hypen");
            var input = Console.ReadLine();

            elements = input.Split('-');

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not consecutive";
            Console.WriteLine(message);
        }
    }
}
