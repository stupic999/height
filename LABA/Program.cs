﻿using System;
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
            Random Rand = new Random();
            int[] r = new int[6];
            int r1 = Rand.Next(1, 43);
            int r2 = Rand.Next(1, 43);
            int r3 = Rand.Next(1, 43);
            int r4 = Rand.Next(1, 43);
            int r5 = Rand.Next(1, 43);
            int r6 = Rand.Next(1, 43);
            int r7 = Rand.Next(1, 43);

            Console.WriteLine("number:{0:00} {1:00} {2:00} {3:00} {4:00} {5:00} {6:00}", r1, r2, r3, r4, r5, r6,r7);

            Console.ReadLine();
        }
    }
}
