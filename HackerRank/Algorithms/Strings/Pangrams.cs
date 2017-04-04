using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    class Pangrams
    {
        public void Main()
        {
            string phrase = Console.ReadLine().ToString().ToLower();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int result = 0;
            foreach (var a in alphabet)
            {
                if (phrase.Contains(a))
                {
                    result += 1;
                }
            }
            if (result == alphabet.Length)
            {
                Console.WriteLine("pangram");
            }
            else
            {
                Console.WriteLine("not pangram");
            }
            Console.ReadKey();
        }
    }
}
