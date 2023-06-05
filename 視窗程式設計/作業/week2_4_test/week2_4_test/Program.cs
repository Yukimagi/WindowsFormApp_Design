namespace test
{
    public class vehicle
    {
        public static int no = 1;
        public vehicle()
        {
            no++;
        }
    }
    public class cars : vehicle
    {
        public new static int num;//一定要加static因為是全域變數，才不會個別計算，會一直計算!
        public cars()
        {
            num++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cars car1 = new cars();
            Console.Write("目前轎車的數目:" + cars.num);
            Console.WriteLine("目前運載工具的數目:" + vehicle.no);
            cars car2 = new cars();
            Console.Write("目前轎車的數目:" + cars.num);
            Console.WriteLine("目前運載工具的數目:" + vehicle.no);
            Console.ReadKey();
        }
    }
}