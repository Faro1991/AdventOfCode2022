using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.HelperObjects
{
    public static class InputParser
    {
        public static List<string> LinesToList(string lines)
        {
            return lines.TrimEnd('\r').Split("\n").Where(x => !string.IsNullOrEmpty(x)).ToList();
        }
    }
}