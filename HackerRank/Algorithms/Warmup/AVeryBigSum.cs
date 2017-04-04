using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class AVeryBigSum
    {
        public void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string values = Convert.ToString(Console.ReadLine());
            long sum = 0;
            foreach (var s in values.Split(new char[] { ' ' }))
            {
                sum += Convert.ToInt64(s);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
