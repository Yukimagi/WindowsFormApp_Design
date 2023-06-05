//練習2-1-3
//int i=5, j=10, a, b;
//int x=5, y=10, c, d;
//a = 1+ i++;
//b = 1+ j--;
//c = 1+ ++x;
//d = 1+ --y;
//求: i, j, x, y, a, b, c, d,
using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5, j = 10, a, b;
            int x = 5, y = 10, c, d;
            a = 1 + i++;
            b = 1 + j--;
            c = 1 + ++x;
            d = 1 + --y;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            //程式暫停，等待使用者輸入一按鍵，然後繼續執行
            Console.ReadKey();
        }
    }
}
