using System;
using static System.Math;
namespace math
{
    class Program
    {
        static void Main(string[] args)
        {

            int d = 2;
            Console.WriteLine("a=Abs(-3)="+Abs(-3));
            Console.WriteLine("a=Ceiling(3.3)="+Ceiling(3.3));
            Console.WriteLine("a = DivRem(5, 3, out int r); a="+DivRem(5, 3, out int r)+"r="+r);
            Console.WriteLine("int d = 2; a = Exp(d)="+Exp(d));//4捨5入，從對第0個變數"Result"將2位取小數
            Console.WriteLine("a = Floor(3.7)="+Floor(3.7));
            Console.WriteLine("a = Log(2)="+ Log(2));
            Console.WriteLine("a = Log10(2)="+ Log10(2));
            Console.WriteLine("a = Max(3, 10)="+Max(3, 10));
            Console.WriteLine("a = Min(3, 10)="+ Min(3, 10));
            Console.WriteLine("a = Pow(2, 5)="+ Pow(2, 5));
            Console.WriteLine("a = Round(3.7)="+Round(3.7));
            int a = Sign(-2);
            Console.WriteLine("a = Sign(-2)=" +a);
            Console.WriteLine("a = Sqrt(2)="+Sqrt(2));
            Console.WriteLine("a = Truncate(2.732)="+Truncate(2.732));
        }
    }
}
