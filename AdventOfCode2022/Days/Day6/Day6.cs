using AdventOfCode2022.HelperObjects;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2022
{
    public class Day6 : DayBase
    {
        public List<string> input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day6/InputDay6.txt"), true);
        private long FindMarker(string Input, int UniqueCharsNeeded)
        {
            for (int i = UniqueCharsNeeded; i < Input.Length; ++i)
            {
                var CharsUntilNow = Input.Take(new Range(i-UniqueCharsNeeded, i)).ToHashSet();
                if (CharsUntilNow.Count() == UniqueCharsNeeded)
                {
                    return i;
                }
            }
            return -1;
        }
        [Benchmark]
        public override long PartOne()
        {
            long Result = 0;
            foreach (string Line in input)
            {
                Result = FindMarker(Line, 4);
            }
            return Result;
        }
        [Benchmark]
        public override long PartTwo()
        {
            long Result = 0;
            foreach (string Line in input)
            {
                Result = FindMarker(Line, 14);
            }
            return Result;
        }
    }
}