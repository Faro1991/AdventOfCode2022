using AdventOfCode2022.HelperObjects;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace AdventOfCode2022
{
    public class Day7 : DayBase
    {
        public List<string> input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day7/InputDay7.txt"), true);
        private Dictionary<string, long> _directoryArchive = new Dictionary<string, long>();
        private List<KeyValuePair<(string, string), long>> DirInfos(string name, int ContinueAt = 0)
        {
            var Result = new List<KeyValuePair<(string, string), long>>();
            var DirInfo = new KeyValuePair<(string, string), long>((name, "Directory"), 0);
            if (input.Count > 0)
            {
                if (_directoryArchive.TryGetValue(name, out _))
                {
                    ContinueAt = (int) _directoryArchive[name];
                }
                if (ContinueAt > input.Count)
                {
                    ContinueAt = 0;
                }
                var DirList = input.GetRange(ContinueAt, input.Count - ContinueAt);
                var start = Math.Min(DirList.IndexOf($"$ cd {name}") + 2, DirList.Count);
                var RelevantPart = DirList.GetRange(start, Math.Abs(DirList.Count - start));
                var ContextEnd = RelevantPart.FindIndex(x => x.StartsWith("$ "));
                if (ContextEnd == -1)                 
                {
                    ContextEnd = RelevantPart.Count;
                }
                var OwnContext = RelevantPart.GetRange(0, ContextEnd);
                var CurrentDepth = ContinueAt + start + 1;
                if (!_directoryArchive.TryAdd(name, CurrentDepth))
                {
                    var CurrentVal = _directoryArchive[name];
                    _directoryArchive[name] = Math.Max(CurrentVal, CurrentDepth);
                    CurrentDepth = (int) _directoryArchive[name];
                }
                long DirSize = 0;
                foreach (string Line in OwnContext)
                {
                    if (char.IsDigit(Line.First()))
                    {
                        var LineInfo = Line.Split(" ");
                        var FileSize = Int64.Parse(LineInfo.First());
                        var FileName = LineInfo.Last();
                        DirSize += FileSize;
                    }
                    else
                    {
                        var DirName = Line.Split(" ").Last();
                        var StartSearching = CurrentDepth;
                        var SubDir = DirInfos(DirName, StartSearching);
                        var SubDirSize = SubDir.Last().Value;
                        var SubDirName = SubDir.Last().Key.Item1;
                        DirSize += SubDirSize;
                        SubDir.AddRange(Result);
                        Result = SubDir;
                    }
                }
                DirInfo = new KeyValuePair<(string, string), long>((name, "Directory"), DirSize);
            }
            Result.Add(DirInfo);
            return Result;
        }
        public override void DayRun()
        {
            try
            {
                long ResultPartOne = PartOne();
                _directoryArchive = new Dictionary<string, long>();
                long ResultPartTwo = PartTwo();

                var Benchmark = BenchmarkRunner.Run(this.GetType(), new DebugInProcessConfig());

                Console.WriteLine("Result part 1: " + ResultPartOne);
                Console.WriteLine("Result part 2: " + ResultPartTwo);
            }
            catch (NotImplementedException NotDoneYet)
            {
                Console.WriteLine($"Not done yet, you still need to implement {NotDoneYet.Source}");
            }
        }
        [Benchmark]
        public override long PartOne()
        {
            var TotalSize = DirInfos("/");
            var OnlyDirectories = TotalSize.Where(x => x.Key.Item2 == "Directory" && x.Value <= 100_000).ToList();
            if (OnlyDirectories.Count == 0)
            {
                OnlyDirectories.Add(new KeyValuePair<(string, string), long>());
            }
            var Result = OnlyDirectories.Sum(x => x.Value);
            return Result;
        }
        [Benchmark]
        public override long PartTwo()
        {
            var TotalSize = DirInfos("/");
            var UnusedSpace = 70_000_000 - TotalSize.Last().Value;
            var SpaceNeeded = Math.Abs(30_000_000 - UnusedSpace);
            var OnlyDirectories = TotalSize.Where(x => x.Key.Item2 == "Directory" && x.Value >= SpaceNeeded).ToList();
            if (OnlyDirectories.Count == 0)
            {
                OnlyDirectories.Add(new KeyValuePair<(string, string), long>());
            }
            var Result = OnlyDirectories.Min(x => x.Value);
            return Result;
        }
    }
}