using AdventOfCode2022.HelperObjects;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2022
{
    public class Day1 : DayBase
    {
        public List<string> input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day1/InputDay1.txt"), false);
        private List<long> _calculateTotals(List<string> input)
        {
            long CurrentVal = 0;
            List<long> result = new List<long>();
            foreach (string line in input)
            {
                if (line != "")
                {
                    CurrentVal += Int64.Parse(line);
                }
                else
                {
                    result.Add(CurrentVal);
                    CurrentVal = 0;
                }
            }
            result.Add(CurrentVal);
            return result;
        }
        [Benchmark]
        public override long PartOne()
        {
            var totals = _calculateTotals(input);
            return totals.Max();
        }
        [Benchmark]
        public override long PartTwo()
        {
            var totals = _calculateTotals(input);
            totals.Sort();
            return totals.TakeLast(3).Sum();
        }
    }
}