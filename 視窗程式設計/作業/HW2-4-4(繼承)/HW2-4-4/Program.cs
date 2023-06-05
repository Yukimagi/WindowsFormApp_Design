/*
定義一父類別與其子類別，使兩者為單一繼承關
係。以飛行物類別當作父類別，且機類別當作子
類別為例
*/

namespace Ex4
{
    public class FlightVehicle//飛行器類別
    {
        public static int num = 1;//目前飛行器數目
        protected string shape;//飛行器外觀
        public FlightVehicle()//建構子
        {
            num ++;//紀錄產生多少飛行器物件
        }
    }
    public class Airplane : FlightVehicle//飛機類別繼承飛行器類別
    {
        public new static int num;//目前飛機的數目//一定要用(new) static//用 static才可以是全域變數才會一起加一
        public string manufactor;//製造商
        public string type;//飛機型號
        public string id;//飛機編號
        private string engineId;//飛機引擎號碼
        public int pilotNum;//飛行員人數
        protected int fuelTank;//飛機油箱容量(L)
        public void SetengineId(string eid)
        {
            engineId = eid;
        }
        public void SetFuelTank()
        {
            fuelTank = 4000;
        }
        public void SetShape()
        {
            shape = "蝙蝠";
        }
        public void ShowData()
        {
            Console.WriteLine("製造商:" +manufactor+" 飛機型號:"+type);
            Console.WriteLine("飛機編號:" + id + " 引擎號碼:" + engineId);
            Console.WriteLine("飛行人員數:" + pilotNum + " 油箱容量(L):" + fuelTank + " 飛機外觀:" + shape);
        }
        public Airplane()//要記得加入建構子(自己的)
        {
            num++;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Airplane aplane = new Airplane();
            aplane.manufactor = "洛克希德馬丁";
            aplane.type = "F-16";
            aplane.id = "American - 1";
            string engineId = "A0001";
            aplane.SetengineId(engineId);
            aplane.pilotNum = Int32.Parse("1");
            aplane.SetFuelTank();
            aplane.SetShape();
            Console.WriteLine("\n飛機物件aplane之相關資訊如下:");
            aplane.ShowData();
            Console.Write("目前的飛機數目:" + Airplane.num);
            Console.WriteLine("目前飛行器的數目:" + FlightVehicle.num);
            //繼承後建構子(祖先)又被執行一次，因此num=2
        }
    }
}
