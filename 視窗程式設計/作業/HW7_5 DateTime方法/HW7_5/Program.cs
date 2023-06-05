using System;

namespace hw7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 12, 25);
            DateTime dt1, dt2;
            //dt1 = dt.AddDays(10);
            Console.WriteLine(dt1 = dt.AddDays(10));
            //dt.CompareTo(new DateTime(1999, 1, 1));
            Console.WriteLine(dt.CompareTo(new DateTime(1999, 1, 1)));
            //dt2 = DateTime.Parse("2021/12/25 15:30:25");
            Console.WriteLine(dt2 = DateTime.Parse("2021/12/25 15:30:25"));
            //dt1.Subtract(dt).ToString()
            Console.WriteLine(dt1.Subtract(dt).ToString());
            dt2.ToShortTimeString();
            Console.WriteLine(dt2.ToShortTimeString());
        }
    }
}
