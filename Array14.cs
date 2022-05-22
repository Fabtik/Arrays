using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array14
    {
        public static void main()
        {
            int N = 0, K = 0;

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

            try
            {
                K = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            for (int i = 0; i < N; i++)
            {
                if (K > 0) K %= N;
                else K = N - ((-K) % N);
            }

            for (int i = N-K; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }

            for (int i = 0; i < N - K; i++)
            {
                Console.Write(array[i] + " ");
            }

            
        }
    }
}
