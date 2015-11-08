using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class UtopianTree
    {
        public void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(UtopianTreeNumber(n));
            }
            Console.ReadKey();
        }

        public static int UtopianTreeNumber(int n)
        {
            int last = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    last = last + 1;
                }
                
                else
                {
                    last = last * 2;
                }
            }
            return last;
        }

    }
}
