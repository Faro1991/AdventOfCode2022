using AdventOfCode2022;
using Xunit;
using System.Collections.Generic;
using System.IO;
namespace AdventOfCode2022.Tests
{
    public class ValidateInputParser
    {
        [Fact]
        public void NoEmptyLines()
        {
            string InputWithEmptyLines = File.ReadAllText(@"HelperObjects/InputParser_Tests_Files/InputWithEmptyLines.txt");
            List<string> ParserResult = AdventOfCode2022.HelperObjects.InputParser.LinesToList(InputWithEmptyLines);
            foreach (var line in ParserResult)
            {
                Assert.NotEmpty(line);
            }
        }
    }
}