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
            int n= 1;
            Random Rand = new Random();
            int[] r = new int[6];
            while (n <50)
            {
                for (int i = 0; i < 6; i++)
                {
                    r[i] = Rand.Next(1, 43);
                }
                System.Threading.Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine("number: {0:00} {1:00} {2:00} {3:00} {4:00} {5:00}", r[0], r[1], r[2], r[3], r[4], r[5]);
                n += 1;
            }
            Console.WriteLine("today prices is: {0:00} {1:00} {2:00} {3:00} {4:00} {5:00}", r[0], r[1], r[2], r[3], r[4], r[5]+", good luck ^^");
            Console.ReadLine();
        }
    }
}
