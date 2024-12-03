using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Common
{
    public static class InputReader
    {
        public static string[] ReadAllLines(string input)
        {
            string[] seperator = { Environment.NewLine };
            return input.Split(seperator, StringSplitOptions.None);
        }
    }
}
