using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите семь чисел");
            int[] array = new int[7];
            float s = 0;
            int k = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
                k++;
            }
            Console.WriteLine("Среднее арифметическое равно {0:f2}", s / k) ;
            Console.ReadKey();
        }
    }
}
