using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 2, 5, 7, 9, -5, 10, 12 };

            for(int i = 0; i<array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine("Indexul negativ se afla pe pozitia " + i);
                }
            }

        }
    }
}
