/*
定義一郵局客戶基本資料類別Postoffice，
 它包含三個私有的(private)屬性name、account 和savings，
它們的資料型態分別為string、string 和int；
 一個公開( public )的Postoffice 建構子用來建立客戶基本資
料
 一個公開( public )無回傳值的ShowData 方法用來顯示客戶
基本資料。
 程式執行時，輸入客戶基本資料，並輸出所輸入的客戶基本資
料。
*/
namespace Ex3
{
    class Postoffice
    {
        private string name;//客戶姓名
        private string account;//客戶帳號
        private int savings;//客戶的存款餘額
        public Postoffice(string name,string account,int deposit)
        {
            this.name = name;//this.name(用this指向自己(name))
            this.account = account;
            savings = deposit;
        }
        //輸入個人的存款餘額
        public void ShowData()
        {
            Console.Write("\n" + name + "先生/小姐，您的存款帳號為" + account);
            Console.WriteLine("，存款餘額為"+savings+".");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Postoffice Emma = new Postoffice("Emma","12345",99999);
            Emma.ShowData();
            Console.ReadKey();
        }
    }
}