using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        
        public static void InsertArray()
        {
            Console.WriteLine("Задача 411:");
            Console.WriteLine("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Въведете " + (i + 1) + " елемент на масива:");
                array[i] = Int32.Parse(Console.ReadLine());
            }

            lNumber(array, length);
        }
        public static void lNumber(int[] array, int length)
        {
            int min = array[0];
            for (int i = 1; i < length; i++)
            {
                if (array[i]<min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Най -малко число:" + min);
        }
        static void Main (string[] args)
        {
            InsertArray();
        }

    }   
        
        
    
}         


