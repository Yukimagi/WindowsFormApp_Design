/*
 定義一計算的類別
 以多載的機制定義
 方法1Area(兩引數)，顯示計算三角形面積，
 方法2Area(兩引數)，顯示計算長方形面積，
 方法3Area(一引數)，顯示計算的正方形面積
 宣告物件
 呼叫方法1(底為5, 高為6.0f)
 呼叫方法2(長為6.0f, 寬為5 )
 呼叫方法3(邊長為6)
*/
namespace Ex2
{
    class computation
    {
        public void Area(int length,float length2)
        {
            Console.Write("底為" + length+"高為" + length2 + "的三角形面積=");
            Console.WriteLine((length * length2)/2);
        }
        public void Area(float length2, int length)
        {
            Console.Write("長為" + length2 + "寬為" + length + "的長方形面積=");
            Console.WriteLine(length * length2);
        }
        public void Area(int length)
        {
            Console.Write("邊長為" + length + "的正方形面積=" );
            Console.WriteLine(length*length);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            computation comp = new computation();
            comp.Area(5, 6.0f);
            comp.Area(6.0f, 5);
            comp.Area(6);
            Console.ReadKey();
        }
    }
}
