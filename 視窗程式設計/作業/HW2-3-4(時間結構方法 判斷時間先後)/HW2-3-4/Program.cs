/*
 *  寫一程式，宣告兩個DateTime結構變數，並分別產生實
例。然後輸入這兩個DateTime結構變數的日期時間，輸
出兩者在日期時間上的先後關係
 例：
輸入第一個日期時間(mm/dd/yyyy hh:mm:ss):
02/01/2023 8:00:00
輸入第二個日期時間(mm/dd/yyyy hh:mm:ss):
01/01/2023 8:00:00
輸出: 02/01/2019 8:00:00 > 01/01/2019 8:00:00
*/
namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //要先另建2個DateTime變數以存兩個string變數
            string s1;
            DateTime d1 = new DateTime();
            string s2;
            DateTime d2 = new DateTime();
            Console.WriteLine("宣告兩個DateTime結構變數，並分別產生實\r\n例。然後輸入這兩個DateTime結構變數的日期時間，輸\r\n出兩者在日期時間上的先後關係");
            Console.Write("輸入第一個日期時間(mm/dd/yyyy hh:mm:ss):");
            s1 = Console.ReadLine();
            Console.Write("輸入第二個日期時間(mm/dd/yyyy hh:mm:ss):");
            s2 = Console.ReadLine();

            //2個DateTime變數以存兩個string變數
            d1 = DateTime.Parse(s1);
            d2 = DateTime.Parse(s2);

            /*若dt1 > dt2，則傳回1，表示dt1晚於dt2
              若dt1 = dt2，則傳回0，表示dt1等於dt2
              若dt1 < dt2，則傳回-1，表示dt1早於dt2
            */

            if(DateTime.Compare(d1, d2) > 0)
            {
                Console.WriteLine("輸出:" +s1 + ">" + s2);
            }
            if (DateTime.Compare(d1, d2) < 0)
            {
                Console.WriteLine("輸出:" + s1 + "<" + s2);
            }
            if (DateTime.Compare(d1, d2) == 0)
            {
                Console.WriteLine("輸出:" + s1 + "=" + s2);
            }
            Console.ReadKey();
        }
    }
}