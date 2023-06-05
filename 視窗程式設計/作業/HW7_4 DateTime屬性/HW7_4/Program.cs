using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 1, 1);
            DateTime dt1 = new DateTime(2021, 1, 1, 15, 33, 15);
            TimeZone tz = TimeZone.CurrentTimeZone;
            //dt.Date.ToString();
            Console.WriteLine(dt.Date.ToString());
            //dt1.TimeOfDay.ToString();
            Console.WriteLine(dt1.TimeOfDay);
            //tz.StandardName.ToString();
            Console.WriteLine(tz.StandardName.ToString());
            //DateTime.Now.ToString();
            Console.WriteLine(DateTime.Now.ToString());
            //dt1.Year.ToString()
            Console.WriteLine(dt1.Year.ToString());
            //TimeZone.CurrentTimeZone.StandardName.ToString();
            Console.WriteLine(TimeZone.CurrentTimeZone.StandardName.ToString());

        }
    }
}
