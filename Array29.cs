using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array29
    {
        public static void main()
        {
            int N = 0, M = 0;

            try
            {
                int[] arr = new int[2];
                arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                N = arr[0];
                M = arr[1];
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int[,] array = new int[N, M];
            int[] tempArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                try
                {
                    tempArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("error FormatException" + '\a');
                    Environment.Exit(0);//прервать выполнение
                }

                for (int j = 0; j < M; j++)
                {
                    array[i, j] = tempArray[j];
                }
            }

            int[,] array2 = new int[M, N];
            int i2=0, j2=N-1;
            for (int i = 0; i < N; i++)
            {
                i2 = 0;
                for (int j = 0; j < M; j++)
                {
                    array2[i2, j2] = array[i, j];
                    i2++;
                }
                j2--;
            }
            
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.Write("\n");
            }


        }
    }
}
