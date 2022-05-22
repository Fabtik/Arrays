using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array16
    {
        public static void main()
        {
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

            int[,] array = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i + j == N-1) array[i, j] = 1;
                    else if (i + j > N-1) array[i, j] = 2;
                    else array[i, j] = 0;
                }                
            }

            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
