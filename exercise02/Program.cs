using System;
using System.Collections.Generic;

namespace exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter few numbers separated by hypen: ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var element in input.Split('-'))
                numbers.Add(Convert.ToInt32(element));

            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);

                else
                {
                    includesDuplicates = true;
                    break;
                }
            }
            if (includesDuplicates)
                Console.WriteLine("Duplicate");
        }
    }
}
