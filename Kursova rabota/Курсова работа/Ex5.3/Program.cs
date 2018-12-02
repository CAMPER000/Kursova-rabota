using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._3
{
    class Program
    {
        static int Pro(int k)
        {
            Console.WriteLine("Задача 377|3:");
            Random rand = new Random();
            List<int> numbers = new List<int>();
            int result = 1;

            for (int i = 0; i < k; i++)
            {
                int currentNum = rand.Next(-100, 100);

                if (currentNum > -10 && currentNum < 10)
                {
                    numbers.Add(currentNum);
                }
            }

            foreach (int num in numbers)
            {
                result *= num;
            }

            return result;
        }

        static void Main(string[] args)
        {

            int a = 15;
            int b = 30;
            int c = 10;

            Console.WriteLine(Pro(Math.Abs(a - b)) * Pro(c));

        }
    }
}
