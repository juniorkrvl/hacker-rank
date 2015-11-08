using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Warmup
{
    class IsFibo
    {
        public void Main()
        {
            long[] fibonacci = new long[90];
            long x = 0, y = 1, z = 0;
            for (long i = 0; i < 90; i++)
            {
                fibonacci[i] = z;
                z = x + y;
                x = y;
                y = z;
            }


            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                long number = long.Parse(Console.ReadLine());
                for (int j = 0; j < 90; j++)
                {
                    if (fibonacci[j] == number)
                    {
                        Console.WriteLine("IsFibo");
                    }
                }
                Console.WriteLine("IsNotFibo");
            }


        }

    }
}
