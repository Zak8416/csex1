using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
           int[] a = new int[n];
            // поемане
            for (int i = 0; i < a.Length; i++)
            {
               a[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(a);

            int x = n < 3 ? n : 3;

            // извеждане
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
