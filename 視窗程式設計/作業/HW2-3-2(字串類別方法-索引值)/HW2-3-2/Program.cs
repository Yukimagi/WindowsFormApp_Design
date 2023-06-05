/* 寫一程式，輸入兩個字串，輸出「字串1」第1次出現在「
字串2」的索引值及最後1次出現的索引值
 例：
輸入目標字串: re
輸入被搜尋字串: Where are you?
"re"第1次出現在"Where are you?"中的索引值為?
"re"最後1次出現在"Where are you?"中的索引值為?*/

/*String.IsNullOrEmpty(變數); 字串變數.Length
字串變數.Substring(整數變數1,整數變數2); 字串變數.ToLower()
字串變數.IndexOf(字元變數); 字串變數1.IndexOf(字串變數2)
字串變數1.EndsWith(字串變數2);
字串變數1.CompareTo(字串變數2)相等=0，大於=1，小於=-1
中文字>英文字>數字，大寫英文字>小寫英文字
字串變數1.Equals(字串變數2)
*/
namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string strings;
            Console.WriteLine("輸入兩個字串，輸出「字串1」第1次出現在「\r\n字串2」的索引值及最後1次出現的索引值");
            Console.Write("輸入目標字串:");
            s =Console.ReadLine();
            Console.Write("輸入被搜尋字串:");
            strings = Console.ReadLine(); ;
            Console.WriteLine("'re'第1次出現在"+"'"+strings+"'中的索引值為:"+strings.IndexOf(s));//記得加strings.
            Console.WriteLine("'re'最後1次出現在" + "'" + strings + "'中的索引值為:"+strings.LastIndexOf(s));
            Console.ReadKey();
        }
    }
}
