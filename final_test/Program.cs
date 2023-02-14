
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            for (int z = 1; z != 0 ; z++)
            {
                string[] arryRndnum = new string[4];
                string[] plNum = new string[4];         
                //宣告變數

                Random rnd = new Random();
                
                    for (int i = 0; i < 4; i++)
                    {
                        arryRndnum[i] = Convert.ToString(rnd.Next(0, 9));

                        if (arryRndnum[0] == "0")
                        {
                            arryRndnum[0] = Convert.ToString(rnd.Next(1, 9));
                        }
                        //第一位數字不為零

                        for (int j = 0; j < i; j++)
                        {
                            if (arryRndnum[j] == arryRndnum[i])
                            {
                                j = 0;
                                arryRndnum[i] = Convert.ToString(rnd.Next(0, 9));
                            }
                        }
                        
                    }
                    //亂數
                    
                




                Console.WriteLine("歡迎來到1A2B猜數字遊戲~");
                for (int k = 1; k != 0; k++)
                {
                    int a = 0, b = 0;
                    Console.WriteLine("---");
                    Console.Write("請輸入不重複的4個數字:");
                    string playNum = Console.ReadLine();
                    Console.WriteLine(playNum);
                    for (int j = 0; j < 4; j++)
                    {
                        plNum[j] = Convert.ToString(playNum[j]);
                    }


                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (plNum[j] == arryRndnum[i])
                            {
                                if (i == j)
                                {
                                    a++;
                                }
                                else
                                {
                                    b++;
                                }
                            }
                        }
                    }
                    Console.WriteLine($"判定結果是 {a}A{b}B");
                    if (a == 4)
                    {   
                        Console.WriteLine("恭喜你!猜對了!!!");
                        break;
                    }
                    
                }
                Console.WriteLine("是否要繼續遊玩?(y/n):");
                string yn = Console.ReadLine();
                if (yn == "n")
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
