using AdventOfCode2022.HelperObjects;
using AdventOfCode2022.FSharpHelpers;

namespace AdventOfCode2022
{
    public class Day2 : DayBase
    {
        private scoreCalculator _calculator = new scoreCalculator();
        public List<string> input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day2/InputDay2.txt"), true);
        public override long PartOne()
        {
            var score = _calculator.total(input);
            return score;
        }
        public override long PartTwo()
        {
            var score = _calculator.optimalScore(input);
            return score;
        }
    }
}