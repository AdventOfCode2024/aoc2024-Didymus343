using AdventOfCode2024.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Day02
{
    public class Day02
    {
        public string First()
        {
            // Get puzzle input
            var input = InputReader.ReadAllLines(Resources._2024_Day02);

            // Display puzzle input
            Console.WriteLine("Input data:");
            foreach (var inputLine in input)
            {
                Console.WriteLine(inputLine);
            }

            // Determine array length
            var size = input.Count();
            Console.WriteLine($"Sample size {size}");

            // Split puzzle input into an list of List<int>
            List<List<int>> totalReports = new List<List<int>>();
            for (int i = 0; i < size; i++)
            {
                var splitResult = input[i].Split(" ", StringSplitOptions.None);
                var report = new List<int>();
                foreach (var s in splitResult)
                {
                    report.Add(Int32.Parse(s));
                }
                totalReports.Add(report);
            }

            var dayResult = 0;

            // For each input line(Report)
            // check if they are safe (follow the rules), or unsafe
            // base on first to numbers check ascending or descending
            foreach (var report in totalReports)
            {
                var isSafe = true;
                var isUp = IsAscending(report[0], report[1]);

                for (int j = 0; j < report.Count - 1; j++)
                {
                    int one = report[j]; int two = report[j + 1];

                    if (IfEqual(one, two))
                    {
                        isSafe = false; break;
                    }

                    if (IsAscending(one, two) != isUp)
                    {
                        isSafe = false; break;
                    }

                    if (MoreThanThree(one, two))
                    {
                        isSafe = false; break;
                    }
                }

                if (isSafe)
                {
                    dayResult++;
                }

                Console.WriteLine($"Report result: {isSafe}, dayResult: {dayResult}");
            }

            return dayResult.ToString();
        }

        public string Second()
        {
            // Get puzzle input
            var input = InputReader.ReadAllLines(Resources._2024_Day02);

            // Display puzzle input
            Console.WriteLine("Input data:");
            foreach (var inputLine in input)
            {
                Console.WriteLine(inputLine);
            }

            // Determine array length
            var size = input.Count();
            Console.WriteLine($"Sample size {size}");

            // Split puzzle input into an list of List<int>
            List<List<int>> totalReports = new List<List<int>>();
            for (int i = 0; i < size; i++)
            {
                var splitResult = input[i].Split(" ", StringSplitOptions.None);
                var report = new List<int>();
                foreach (var s in splitResult)
                {
                    report.Add(Int32.Parse(s));
                }
                totalReports.Add(report);
            }

            var dayResult = 0;

            // For each input line(Report)
            // check if they are safe (follow the rules), or unsafe
            // base on first to numbers check ascending or descending
            foreach (var report in totalReports)
            {
                var isSafe = true;
                var isUp = IsAscending(report[0], report[1]);

                for (int j = 0; j < report.Count - 1; j++)
                {
                    int one = report[j]; int two = report[j + 1];

                    if (IfEqual(one, two))
                    {
                        isSafe = false; break;
                    }

                    if (IsAscending(one, two) != isUp)
                    {
                        isSafe = false; break;
                    }

                    if (MoreThanThree(one, two))
                    {
                        isSafe = false; break;
                    }
                }

                if (isSafe)
                {
                    dayResult++;
                }

                Console.WriteLine($"Report result: {isSafe}, dayResult: {dayResult}");
            }

            return dayResult.ToString();
        }

        private bool IfEqual(int one, int two)
        {
            if(one == two) return true;
            return false;
        }

        private bool MoreThanThree(int one, int two)
        {
            if (Math.Abs(one - two) > 3) return true;
            return false;
        }

        private bool IsAscending(int one, int two)
        {
            if((two - one) > 0) return true;
            return false;
        }
    }
}
