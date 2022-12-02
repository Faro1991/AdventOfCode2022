namespace AdventOfCode2022.HelperObjects
{
    public static class InputParser
    {
        public static List<string> LinesToList(string lines, bool removeEmptyLines)
        {
            if (removeEmptyLines)
            {
                return lines.TrimEnd('\r').Split("\n").Where(x => !string.IsNullOrEmpty(x) == removeEmptyLines).ToList();
            }
            return lines.TrimEnd('\r').Split("\n").ToList();
        }
    }
}