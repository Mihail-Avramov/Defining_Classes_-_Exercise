using System;

namespace Date_Modifier
{
    public static class DateModifier
    {
        public static int GetDifference(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);

            int days = endDate.Subtract(startDate).Days;
            //int days = (endDate - startDate).Days;
            
            return Math.Abs(days);
        }
    }
}
