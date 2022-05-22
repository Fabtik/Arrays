 using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array27
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
            int k = 0;
            int i = 0;
            int j = 0;
            int ik = 0;
            int jk = 1;


            while (k<N*M)
            {
                array[i, j] = k;
               
                if (i + 1 < N && j - 1 > -1)
                {
                    i++;
                    j--;
                }
                else
                {
                    i = ik;
                    j = jk;
                    if (jk + 1 < M)
                    {
                        jk++;
                    }
                    else ik++;
                }

                k++;                
            }

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.Write("\n");
            }


        }
    }
}
