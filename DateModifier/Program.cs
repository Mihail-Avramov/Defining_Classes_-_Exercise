using System;

namespace Date_Modifier
{
    public class Startup
    {
        static void Main()
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            int daysDifference = DateModifier.GetDifference(startDate, endDate);

            Console.WriteLine(daysDifference);

        }
    }
}

