using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array17
    {
        public static void main()
        {
            int N = 0;
            bool isSymmetric = true;

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
            int[] tempArray = new int[N];
            for(int i = 0; i < N; i++)
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

                for(int j = 0; j < N; j++)
                {
                    array[i, j] = tempArray[j];
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array[i, j] != array[j, i] && i !=j) isSymmetric = false;
                    
                }
            }

            if (isSymmetric) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
