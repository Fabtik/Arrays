using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array18
    {
        public static void main()
        {
            int N = 0, M = 0, tempSum = 0, maxSum = 0, maxSumIndex = 0;
            bool isSymmetric = true;

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
                    tempSum += array[i, j];
                }
                
                if(tempSum > maxSum)
                {
                    maxSum = tempSum;
                    tempSum = 0;
                    maxSumIndex = i;
                }
            }

            Console.WriteLine(maxSum);
            Console.WriteLine(maxSumIndex);
        }
    }
}
