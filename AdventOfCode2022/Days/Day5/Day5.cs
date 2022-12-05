using AdventOfCode2022.HelperObjects;
using AdventOfCode2022.HelperObjects.DataTypes;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace AdventOfCode2022
{
    public class Day5 : DayBase
    {
        public List<string> input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day5/InputDay5.txt"), false);
        private List<CrateStack> _stacks = new List<CrateStack>();
        [Benchmark]
        public override long PartOne()
        {
            var ResultPartOne = this.PartOne(true);
            this._stacks = new List<CrateStack>();
            return 0;
        }
        [Benchmark]
        public override long PartTwo()
        {
            var ResultPartTwo = this.PartTwo(true);
            this._stacks = new List<CrateStack>();
            return 0;
        }
        public override void DayRun()
        {
            var ResultPartOne = this.PartOne(true);
            this._stacks = new List<CrateStack>();
            var ResultPartTwo = this.PartTwo(true);

            var Benchmark = BenchmarkRunner.Run(this.GetType(), new DebugInProcessConfig());

            Console.WriteLine("Result part 1: " + ResultPartOne);
            Console.WriteLine("Result part 2: " + ResultPartTwo);
        }
        private void BuildCrates(int EmptyRow)
        {
            var NumberOfCrates = Int64.Parse(input[EmptyRow].Split(" ").Where(x => x != "").Last());
            for (int i = 0; i < NumberOfCrates; ++i)
            {
                this._stacks.Add(new CrateStack());
            }
            for (int c = EmptyRow - 1; c >= 0; --c)
            {
                var Line = input[c];
                var Crates = Line.Chunk(4).ToList();
                for (int i = 0; i < Crates.Count; ++i)
                {
                    var CrateType = Crates[i][1];
                    if (char.IsLetter(CrateType))
                    {
                        this._stacks[i].PushCrate(CrateType.ToString());
                    }
                }
            }
        }
        private List<string[]> gatherInstructions(int EmptyRow)
        {
            var Result = new List<string[]>();
            for (int ins = EmptyRow + 1; ins < input.Count; ++ins)
            {
                var LineNumbers = input[ins].Replace("move ", "").Replace("from ", "").Replace("to ", "").Split(" ");
                if (!String.IsNullOrEmpty(LineNumbers.First()))
                {
                    Result.Add(LineNumbers);
                }
            }
            return Result;
        }
        private string GetResults()
        {
            var Result = "";
            foreach(CrateStack Stack in this._stacks)
            {
                Result += Stack.PopCrate();
            }
            return Result;
        }
        public string PartOne(bool ReturnString)
        {
            var CratesEndAt = input.IndexOf("");
            this.BuildCrates(CratesEndAt - 1);

            var LineNumbers = this.gatherInstructions(CratesEndAt);

            foreach (string[] Line in LineNumbers)
            {
                var Steps = Int32.Parse(Line.First());
                var Source = Int32.Parse(Line[1]) - 1;
                var Target = Int32.Parse(Line.Last()) - 1;
                for (int Step = 0; Step < Steps; ++Step)
                {
                    var MovingCrate = this._stacks[Source].PopCrate();
                    if (!this._stacks[Target].PushCrate(MovingCrate))
                    {
                        throw new Exception($"Unable to move crate '{MovingCrate}' from stack {Source} to stack {Target}, current step: {Step}");
                    }
                }
            }
            return this.GetResults();
        }
        public string PartTwo(bool ReturnString)
        {
            var CratesEndAt = input.IndexOf("");
            this.BuildCrates(CratesEndAt - 1);

            var LineNumbers = this.gatherInstructions(CratesEndAt);

            foreach (string[] Line in LineNumbers)
            {
                var Steps = Int32.Parse(Line.First());
                var Source = Int32.Parse(Line[1]) - 1;
                var Target = Int32.Parse(Line.Last()) - 1;
                var MovingCrates = "";
                for (int Step = 0; Step < Steps; ++Step)
                {
                    MovingCrates += this._stacks[Source].PopCrate();
                }
                for (int i = MovingCrates.Length - 1; i >= 0; --i)
                {
                    this._stacks[Target].PushCrate(MovingCrates[i].ToString());
                }
            }
            return this.GetResults();
        }
    }
}