using AdventOfCode2022.HelperObjects;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2022
{
    public class Day4: DayBase
    {
        public List<string> input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day4/InputDay4.txt"), true);
        private bool AssignmentTester(string FirstRange, string SecondRange, bool FullyOverlap)
        {
            var FirstSplit = FirstRange.Split("-");
            var SecondSplit = SecondRange.Split("-");
            var FirstStart = Int64.Parse(FirstSplit.First());
            var FirstEnd = Int64.Parse(FirstSplit.Last());
            var SecondStart = Int64.Parse(SecondSplit.First());
            var SecondEnd = Int64.Parse(SecondSplit.Last());

            var FirstInSecond = (FirstStart >= SecondStart && FirstEnd <= SecondEnd);
            var SecondInFirst = (FirstStart <= SecondStart && FirstEnd >= SecondEnd);
            if (!FullyOverlap)
            {
                FirstInSecond = FirstInSecond || (FirstEnd >= SecondStart && FirstEnd <= SecondStart);
                SecondInFirst = SecondInFirst || (FirstStart <= SecondEnd && FirstEnd >= SecondStart);
            }
            return (FirstInSecond || SecondInFirst);
        }
        [Benchmark]
        public override long PartOne()
        {
            long Result = 0;
            foreach (string line in input)
            {
                var Assignments = line.Split(",");
                var FirstRange = Assignments.First();
                var SecondRange = Assignments.Last();

                if (AssignmentTester(FirstRange, SecondRange, true))
                {
                    ++Result;
                }
            }
            return Result;
        }
        [Benchmark]
        public override long PartTwo()
        {
            long Result = 0;
            foreach (string line in input)
            {
                var Assignments = line.Split(",");
                var FirstRange = Assignments.First();
                var SecondRange = Assignments.Last();

                if (AssignmentTester(FirstRange, SecondRange, false))
                {
                    ++Result;
                }
            }
            return Result;
        }
    }
}