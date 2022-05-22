using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array8
    {
        public static void main()
        {
            int N = 0, temp;

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

            for (int i = 1; i < N; i+=2)
            {
                temp = array[i];
                array[i] = array[i - 1];
                array[i-1] = temp;
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
