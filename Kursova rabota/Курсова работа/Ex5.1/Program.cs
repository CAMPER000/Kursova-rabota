using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Задача 377:");
            Random rng = new Random();
            int a = 0;

            for (int i = 1; i <= 55; i++)
            {
                a = rng.Next(-100, 100);
                if (a < 0)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
