//回家作業2-1-1
//主控台應用程式
// 列舉型態Season，且其成員有Spring，Summer，Fall 及Winter，令Spring = 1
// 列印所有成員
// 列印所有成員值
// 將“Fall”直接轉成成員值
// 成員值1直接轉成成員

using System;

namespace test
{
    class Program
    {
        public enum Season { Spring = 1, Summer, Fall, Winter };//指定spring為1        
        static void Main(string[] args)
        {
            Season s = Season.Fall;
            foreach (string en in Enum.GetNames(typeof(Season)))
                Console.WriteLine(en);

            foreach (int v in Enum.GetValues(s.GetType()))
                Console.WriteLine(v);

            Console.Write("{0}所代表的常數值={1}\n", s, (int)s);//將"Fall"直接轉成成員值3
            int k = 1;
            Season st = (Season)k;//將成員值1直接轉成成員
            Console.WriteLine("Int to Enum: " + st);

            //程式暫停，等待使用者輸入一按鍵，然後繼續執行
            Console.ReadKey();
        }
    }
}
