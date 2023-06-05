using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            float j = 1.5f;
            Console.WriteLine("i={0}\n", i);
            //Q: 若Console.WriteLine(“i={0}”, i); 要同時印I, j?
            Console.WriteLine("j= " + j + "\n");
        }
    }
}
