using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～");
            Random rand = new Random(Guid.NewGuid().GetHashCode()); 
            List<int> listLinq = new List<int>(Enumerable.Range(0, 9));//先設定0至9的數值範圍
            listLinq = listLinq.OrderBy(num => rand.Next()).ToList<int>(); 
            string[] arr = new string[4];
            string[] arr2 = new string[4];
            for (int i = 0; i < 4; i++)//隨機亂數產生4個不重複數值
            {
                arr[i] = Convert.ToString(listLinq[i]);
                //(listLinq[i].ToString());
            }
            bool Iswin = false;
            do
            {
                if (Iswin = false)
                {
                    Console.WriteLine("請輸入4個數字：");
                    int a = 0;
                    int b = 0;
                    string guessnum = Console.ReadLine();
                    for (int i=0; i<4;i++)//判斷A
                    {
                        arr2[i] = Convert.ToString((string)guessnum[i]);
                        if (arr[i] == guessnum[i])
                        {
                            a += 1;
                        }
                        break;
                    }
                    foreach (int i in arr[];)//判斷B
                    {
                        if (guessnum[i])

 }
                    Console.WriteLine("判定結果是：");
                }
                else
                {
                    Console.WriteLine("輸入格式錯誤！");
                }
            } while (true);//結束
            Console.WriteLine("你要繼續玩嗎？");
            Console.WriteLine("遊戲結束，下次再來玩喔～");
            */






            int i  = 50;
            Console.WriteLine(i);

            for ( i = 0;i < 5; i++) {
                 
            }

            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
