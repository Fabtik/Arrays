using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array26
    {
        public static void main()
        {
            int N = 0, M = 0;
            char direction = 'd'; // d - right, a - left

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

            

            int i = 0, j = 0;
            int k = 0;
            while (k < N * M)
            {
                array[i, j] = k;

                if (direction == 'd')
                {
                    j++;
                    if(j == M)
                    {
                        i++;
                        direction = 'a';
                    }
                }
                
                if(direction == 'a')
                {
                    j--;
                    if(j == -1)
                    {
                        j++;
                        i++;
                        direction = 'd';
                    }               
                }
               
                k++;
            }

            for(i = 0; i < N; i++)
            {
                for(j = 0; j < M; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.Write("\n");
            }


        }

        
    }
}
