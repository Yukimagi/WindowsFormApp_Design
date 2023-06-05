//作業
//練習2-1-2
// char ch = 'X';
// short s = -5;
// int i = 6;
// float f = 9.7f;
// double d = 1.76;
// 求(s*ch)-(d/f)*(i+f)=?
using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'X';
            short s = -5;
            int i = 6;
            float f = 9.7f;
            double d = 1.76;
            double result = (s * ch) - (d / f) * (i + f);//-442.(...)//char<<short<<(被後者取代) int<<float<<double
            Console.WriteLine("(s*ch)-(d/f)*(i+f)=");
            Console.WriteLine(result);
            Console.WriteLine("{0:F2}", result);//4捨5入，從對第0個變數"Result"將2位取小數
            double r1 = Math.Round(result, 1);
            Console.WriteLine(r1);
            //程式暫停，等待使用者輸入一按鍵，然後繼續執行
            Console.ReadKey();
        }
    }
}

