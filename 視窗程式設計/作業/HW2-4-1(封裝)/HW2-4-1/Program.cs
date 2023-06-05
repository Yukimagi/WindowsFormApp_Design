/*
 定義汽車類別
 屬性: 車號、汽油量
 方法1(有引數): 顯示車號
 方法2(有引數): 顯示汽油量
 方法3(無引數): 同時顯示車號與汽油量
 宣告car1
 呼叫方法1(有引數)
 呼叫方法2(有引數)
 呼叫方法3(無引數)
*/
namespace Ex1
{
    class Car
    {
        private int num;
        private double gas;
        public void setNum(int n)
        {
            num = n;
        }
        public void setGas(double g)
        {
            gas = g;
        }
        public void show()
        {
            Console.WriteLine("車號: " + num + " "+"油量: " + gas);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.setNum(123);
            car1.setGas(25.5);
            car1.show();
            Console.ReadKey();
        }
    }
}