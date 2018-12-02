using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 14:");
            Console.WriteLine("Въведете стойности за a1, d  и n. S = ?");

            Console.WriteLine("Въведена стойност за а1:");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведена стойност за d:");
            double sec = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведен брой на членовете n:");
            double n = double.Parse(Console.ReadLine());

            double var1 = ((2 * first + sec* (n - 1)) * n)* 0.5;
            Console.WriteLine("S = {0}", var1);                      
        }
    }
}
