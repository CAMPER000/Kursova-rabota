using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 213|ж:");
            
            double next = 0.0;


            for (int i = 100; i > 0; i --)       
            {                
                next = Math.Tan(i + next);
                
                Console.WriteLine(next);
            }
            
        }
    }
}
