﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            x = 9; y = 9;

            if (x == y)
                Console.WriteLine("X is equal to y");
            else if (x != y)
            {
                //nested if
                if (x > y)
                    Console.WriteLine("X is greater than y");
                else if (x < y)
                    Console.WriteLine("X is less than y");
            }
               

        }
    }
}
