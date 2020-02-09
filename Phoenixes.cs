using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cc = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            cc.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = cc;


            int N = int.Parse(Console.ReadLine());
            int[] precision = new int[N];
            decimal[] totalYears = new decimal[N];
            decimal[] totalLength = new decimal[N];
            decimal[] totalWidth = new decimal[N];
            decimal[] wingLength = new decimal[N];

            for (int i = 0; i < N; i++)
            {
                totalLength[i] = decimal.Parse(Console.ReadLine());
                totalWidth[i] = decimal.Parse(Console.ReadLine());
                wingLength[i] = decimal.Parse(Console.ReadLine());


                if (totalWidth[i] != (decimal)totalWidth[i])
                    precision[i] = totalWidth[i].ToString().Split('.')[1].Length;
                else precision[i] = 0;

                totalYears[i] = totalLength[i] * totalLength[i] * (totalWidth[i] + 2 * wingLength[i]);
            }


            for (int i = 0; i < N; i++)
            {
                if (totalYears[i] == (decimal)totalYears[i])
                    Console.WriteLine(totalYears[i]);
                else
                    Console.WriteLine(Math.Round(totalYears[i], precision[i]));
            }         
        }
    }
}
