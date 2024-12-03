using AdventOfCode2024.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Day01
{
    public class Day01
    {
        public string Second()
        {
            // Get puzzle input
            var input = InputReader.ReadAllLines(Resources._2024_Day01);

            // Display puzzle input
            Console.WriteLine("Input data:");
            foreach (var inputLine in input)
            {
                Console.WriteLine(inputLine);
            }

            // Determine array length
            var size = input.Count();
            Console.WriteLine($"Sample size {size}");

            // Split puzzle input into left and right array of int
            int[] left = new int[size], right = new int[size];
            for (int i = 0; i < size; i++)
            {
                var splitResult = input[i].Split("   ", StringSplitOptions.None);
                left[i] = (Int32.Parse(splitResult[0]));
                right[i] = (Int32.Parse(splitResult[1]));
            }

            // Sort both arrays in ascending order
            Array.Sort(left);
            Array.Sort(right);

            // 
            var dayResult = 0;
            for (int i = 0; i < size; i++)
            {
                var leftNumber = left[i];
                var count = 0;
                foreach (var rightNumber in right)
                {
                    if (leftNumber == rightNumber)
                    {
                        count++;
                    }
                }
                var result = leftNumber * count;
                dayResult += result;

                Console.WriteLine($"Left: {leftNumber}, count: {count}, total: {result}");
            }

            Console.WriteLine($"Total day result {dayResult}");
            return dayResult.ToString();
        }

         public string First()
        {
            // Get puzzle input
            var input = InputReader.ReadAllLines(Resources._2024_Day01);

            // Display puzzle input
            Console.WriteLine("Input data:");
            foreach (var inputLine in input)
            {
                Console.WriteLine(inputLine);
            }

            // Determine array length
            var size = input.Count();
            Console.WriteLine($"Sample size {size}");

            // Split puzzle input into left and right array of int
            int[] left = new int[size], right = new int[size];
            for (int i = 0; i < size; i++)
            {
                var splitResult = input[i].Split("   ", StringSplitOptions.None);
                left[i] = (Int32.Parse(splitResult[0]));
                right[i] = (Int32.Parse(splitResult[1]));
            }

            // Sort both arrays in ascending order
            Array.Sort(left);
            Array.Sort(right);

            // Combine sorted arrays to find differences & Add all differences together
            var dayResult = 0;
            for (int i = 0; i < size; i++)
            {
                var result = Math.Abs(left[i] - right[i]);
                dayResult += result;

                Console.WriteLine($"Left: {left[i]}, right: {right[i]}, difference: {result}");
            }

            Console.WriteLine($"Total day result {dayResult}");
            return dayResult.ToString();
        }
    }
}
