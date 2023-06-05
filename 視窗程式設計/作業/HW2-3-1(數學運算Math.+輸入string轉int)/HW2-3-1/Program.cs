/*
 寫一程式，由鍵盤輸入a, b, c，求一元二次方程式
ax2+bx+c=0的兩個根，其中b2-4ac>=0
 例:
輸入a = 1, b = 2, c = 1
輸出x =?*/
namespace Ex1
{ 
class Program
{
    static void Main(string[] args)
    {
        int a, b,c;
        Console.WriteLine("輸入方程式ax^2+bx+c的係數，a,b,c");
        Console.Write("輸入第一個整數 a=:");
        a=Int32.Parse(Console.ReadLine());
        Console.Write("輸入第二個整數 b=:");
        b=Int32.Parse(Console.ReadLine());
        Console.Write("輸入第二個整數 c=:");
        c = Int32.Parse(Console.ReadLine());
        
        //記得加Math.
        double result1 = ((-1*b) +Math.Sqrt(Math.Pow(b,2) -(4*a*c)))/ 2 * a;
        double result2 = ((-1 * b) - Math.Sqrt(b * b - (4 * a * c))) / 2 * a;
        Console.Write(a+ "x^2+"+b+"x+" + c + "=0的根為");
        Console.Write(result1+"及"+result2);
        Console.ReadKey();
    }
}
}