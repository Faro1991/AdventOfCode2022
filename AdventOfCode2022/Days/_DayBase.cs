using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
namespace AdventOfCode2022.HelperObjects
{
    public abstract class DayBase
    {
        public abstract long PartOne();
        public abstract long PartTwo();

        public virtual void DayRun()
        {
            try
            {
                long ResultPartOne = PartOne();
                long ResultPartTwo = PartTwo();

                var Benchmark = BenchmarkRunner.Run(this.GetType(), new DebugInProcessConfig());

                Console.WriteLine("Result part 1: " + ResultPartOne);
                Console.WriteLine("Result part 2: " + ResultPartTwo);

                //TODO: auto update readme
                //if (!File.ReadAllText("../../Readme.md").Contains($"### Day {DayCalculator.AoCDay()}"))
                //{
                //    var Header = Benchmark.Table.FullHeader
                //    File.AppendAllText("../../Readme.md",$"### Day {DayCalculator.AoCDay()}\n{Benchmark.Table}");
                //}
            }
            catch (NotImplementedException NotDoneYet)
            {
                Console.WriteLine($"Not done yet, you still need to implement {NotDoneYet.Source}");
            }
        }
    }
}