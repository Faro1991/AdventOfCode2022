using AdventOfCode2022.HelperObjects;
using AdventOfCode2022.FSharpHelpers;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2022
{
    public class Day6 : DayBase
    {
        public List<string> input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day6/InputDay6.txt"), true);
        [Benchmark]
        public override long PartOne()
        {
            long Result = 0;
            foreach (string Line in input)
            {
                Result = signalFinder.findSignal(Line, 4);
            }
            return Result;
        }
        [Benchmark]
        public override long PartTwo()
        {
            long Result = 0;
            foreach (string Line in input)
            {
                Result = signalFinder.findSignal(Line, 14);
            }
            return Result;
        }
    }
}