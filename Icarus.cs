using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitters = {' '};
            string[] s = Console.ReadLine().Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            int n = s.Length;
            int[] plane = new int[n];

            for (int i = 0; i < n; i++)
                plane[i] = int.Parse(s[i]);

            int CurrPos = int.Parse(Console.ReadLine());
            int damage = 1;

            string[] command;
            string direction = "";
            int steps = 0;

            do
            {
                command = Console.ReadLine().Split(splitters, StringSplitOptions.RemoveEmptyEntries);
                if (command.Length > 1)
                {
                    direction = command[0];
                    steps = int.Parse(command[1]);
                }

                // processing commands
                if (direction == "left")
                {
                    CurrPos -= steps % n;
                    damage += steps / n;
                }


            }
            while (command[0] != "Supernova");

            Console.WriteLine();
        }
    }
}
