using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array10
    {
        public static void main()
        {
            int N = 0, max;

            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int[] array = new int[N];
            try
            {
                array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            max = array[0];
            for (int i = 1; i < N; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            Console.WriteLine(max);
        }
    }
}
