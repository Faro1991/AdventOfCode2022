namespace AdventOfCode2022.HelperObjects
{
    static class DayCalculator
    {
        public static long AoCDay()
        {
            var Today = DateTime.Today;
            var December1st = new DateTime(DateTime.Today.Year, 11, 30);
            TimeSpan DifferenceToDecember1st = Today - December1st;
            return DifferenceToDecember1st.Days;
        }
    }
}