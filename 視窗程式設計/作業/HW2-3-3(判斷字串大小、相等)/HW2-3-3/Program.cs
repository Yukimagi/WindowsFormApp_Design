/*
 寫一程式，輸入兩個字串，比較兩個字串的大小及判斷兩
個字串是否相等
 例：
輸入字串1: What a beautiful day!
輸入字串2: What A Beautiful Day!
(1)比較方法「CompareTo()」:大小寫不同視為不同:
"What a beautiful day!"小於"What A Beautiful Day!"
(2)判斷方法「Equals()」:大小寫不同視為不同:
"What a beautiful day!"不等於"What A Beautiful Day!"
*/
namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string s2;
            Console.WriteLine("輸入兩個字串，比較兩個字串的大小及判斷兩\r\n個字串是否相等");
            Console.Write("輸入字串1:");
            s1 = Console.ReadLine();
            Console.Write("輸入字串2:");
            s2 = Console.ReadLine();

            //s1.CompareTo(s2)是比ASCII
            if (s1.CompareTo(s2) > 0)
            {
                Console.WriteLine("'" + s1 + "'" + "大於" + "'" + s2 + "'");
            }
            if (s1.CompareTo(s2) < 0)
            {
                Console.WriteLine("'"+s1+ "'" + "小於" + "'"+s2+ "'");
            }
            if (s1.CompareTo(s2) == 0)
            {
                Console.WriteLine("'"+s1+ "'" + "等於" + "'"+s2+ "'");
            }
            
            if (s1.Equals(s2) == true)
            {
                Console.WriteLine("'" + s1 + "'" + "等於" + "'" + s2 + "'");
            }
            if (s1.Equals(s2) == false)
            {
                Console.WriteLine("'" + s1 + "'" + "不等於" + "'" + s2 + "'");
            }
            Console.ReadKey();
        }
    }
}

