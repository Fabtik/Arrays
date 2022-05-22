using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array21
    {
        public static void main()
        {
            int N = 0, M = 0, Max = 0, counter = 0;
            bool isMax = false;

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
            int[] tempArray = new int[M];
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


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (Max < array[i, j])
                    {
                        Max = array[i, j];
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                isMax = false;
                for (int j = 0; j < M; j++)
                {
                    if (array[i, j] == Max)
                    {
                        isMax = true;
                    }
                }

                if (isMax) counter++;
            }

            Console.WriteLine(counter);

        }
    }
}
