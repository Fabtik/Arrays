using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array6
    {
        public static void main()
        {
            int N = 0, counter = 0;

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

            for (int i = 1; i < N; i++)
            {
                if (i+1 < N)
                {
                    if(array[i] > array[i-1] && array[i] > array[i + 1])
                    {
                        counter++;
                    }
                }
            }


            Console.WriteLine(counter);
        }
    }
}
