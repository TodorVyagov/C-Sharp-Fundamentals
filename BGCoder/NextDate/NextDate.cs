using System;

namespace NextDate
{
    class NextDate
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime thisDate = new DateTime(year, month, day);
            thisDate = thisDate.AddDays(1);
            Console.WriteLine(thisDate.ToString("d.M.yyyy"));
        }
    }
}
