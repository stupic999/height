using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA
{
    class Program
    {
        static void Main(string[] args)
        {
            // 設定一個數字n為1
            int n= 1;

            // 產生隨機的指令
            Random Rand = new Random();

            // 當n小於等於10，執行內部的指令
            while (n <= 10)
            {
                // 設定r1，隨機從1到42選取一個數帶入
                int r1 = Rand.Next(1, 43);

                // 設定r2，隨機從1到42選取一個數帶入
                int r2 = Rand.Next(1, 43);

                // 設定r3，隨機從1到42選取一個數帶入
                int r3 = Rand.Next(1, 43);

                // 設定r4，隨機從1到42選取一個數帶入
                int r4 = Rand.Next(1, 43);

                // 設定r5，隨機從1到42選取一個數帶入
                int r5 = Rand.Next(1, 43);

                // 設定r6，隨機從1到42選取一個數帶入
                int r6 = Rand.Next(1, 43);

                // {0:00}就是第1個數字，也就是0，如果他的數只有1，那顯示出來就會是01, (顯示“number:[n] r1 r2 r3 r4 r5 r6”)
                Console.WriteLine("number:[{0:00}] {1:00} {2:00} {3:00} {4:00} {5:00} {6:00}",n, r1, r2, r3, r4, r5, r6);
                
                // n+1
                n += 1;
            }

            // 按任何一個按鈕即可退出
            Console.ReadKey();
        }
    }
}
