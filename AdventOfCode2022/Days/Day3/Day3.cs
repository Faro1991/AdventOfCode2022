using AdventOfCode2022.HelperObjects;
using BenchmarkDotNet.Attributes;
using Microsoft.ClearScript.V8;

namespace AdventOfCode2022
{
    class Day3 : DayBase
    {
        public List<string> input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day3/InputDay3.txt"), true);
        private string _scriptSource = File.ReadAllText("Days/Day3/Solver.js");
        private V8ScriptEngine _js = new V8ScriptEngine();
        private dynamic _arrayToPass = new string[] {};

        public Day3()
        {
            _js.Execute(_scriptSource);
            var ArrayToPass = _js.Script.Array.from(input.ToArray());
            _arrayToPass = ArrayToPass;
        }
        [Benchmark]
        public override long PartOne()
        {
            long Result = 0;
            Result = _js.Script.solvePartOne(_arrayToPass);
            return Result;
        }
        [Benchmark]
        public override long PartTwo()
        {
            long Result = 0;
            Result = _js.Script.solvePartTwo(_arrayToPass);
            return Result;
        }
    }
}