using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.IO;
namespace AdventOfCode2022.HelperObjects
{
    public abstract class DayBase
    {
        [Benchmark]
        public abstract long PartOne();
        [Benchmark]
        public abstract long PartTwo();

        public virtual void DayRun()
        {
            try
            {
                List<string> inputLines = new List<string>();
                var currentFileNameList = new DirectoryInfo(".").GetFiles("InputDay*.txt");
                foreach (var file in currentFileNameList)
                {
                    inputLines = InputParser.LinesToList(File.ReadAllText(file.FullName));
                }
                long ResultPartOne = PartOne();
                long ResultPartTwo = PartTwo();
                BenchmarkRunner.Run(this.GetType());
            }
            catch (NotImplementedException NotDoneYet)
            {
                Console.WriteLine($"Not done yet, you still need to implement {NotDoneYet.Source}");
            }
        }
    }
}