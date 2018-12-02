using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Десетичното число 2084 е:");
            Console.WriteLine("{0} като двоично.", Convert.ToString(2084, 2));
            
            Console.WriteLine("Десетичното число 2084 е:");
            Console.WriteLine("{0} като осмично.", Convert.ToString(2084, 8));

            Console.WriteLine("Десетичното число 2084 е:");
            Console.WriteLine("{0} като шеснайстично.", Convert.ToString(2084, 16));
        }
        

        

    }
}
