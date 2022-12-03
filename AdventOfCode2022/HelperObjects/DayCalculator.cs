namespace AdventOfCode2022.HelperObjects
{
    static class DayCalculator
    {
        private static DateTime _today = DateTime.Today;
        public static long AoCDay()
        {
            var December1st = new DateTime(DateTime.Today.Year, 11, 30);
            TimeSpan DifferenceToDecember1st = _today - December1st;
            return DifferenceToDecember1st.Days;
        }
        public static bool OnlineYet()
        {
            var IsEstMidnight = _today.ToUniversalTime().AddHours(-5);
            var OwnDifference = _today - _today.ToUniversalTime();
            if (OwnDifference.Hours > 0)
            {
                return IsEstMidnight.Day >= _today.Day;
            }
            return IsEstMidnight.Day <= _today.Day;
        }
    }
}