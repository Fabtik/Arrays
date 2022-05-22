using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array31
    {
        public static void main()
        {
            int[] x = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int N = 0;

            try
            {               
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int i = 0;
            while (N > x[i])
            {
                N -= x[i];
                i++;
            }

            Console.WriteLine(N + " " + (i + 1));
        }
    }
}
