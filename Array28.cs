using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array28
    {
        public static void main()
        {
            int N = 0, M = 0, W = 0;
            int[] arr = new int[2];
            try
            {
                
                arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                W = Convert.ToInt32(Console.ReadLine());
                N = arr[0];
                M = arr[1];
                
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int[,] array = new int[N, M];
            for (int i = 0; i < W; i++)
            {
                try
                {
                    arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    array[arr[0] - 1, arr[1] - 1] = 8;
                    
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("error FormatException" + '\a');
                    Environment.Exit(0);//прервать выполнение
                }
                                
            }

            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {   
                    if(array[i, j] != 8)
                    {
                        try
                        {
                            if (array[i - 1, j] == 8) array[i, j]++;
                        }
                        catch (IndexOutOfRangeException) { }

                        try
                        {
                            if (array[i - 1, j + 1] == 8) array[i, j]++;
                        }
                        catch (IndexOutOfRangeException) { }

                        try
                        {
                            if (array[i, j + 1] == 8) array[i, j]++;
                        }
                        catch (IndexOutOfRangeException) { }

                        try
                        {
                            if (array[i + 1, j + 1] == 8) array[i, j]++;
                        }
                        catch (IndexOutOfRangeException) { }

                        try
                        {
                            if (array[i + 1, j] == 8) array[i, j]++;
                        }
                        catch (IndexOutOfRangeException) { }

                        try
                        {
                            if (array[i + 1, j - 1] == 8) array[i, j]++;
                        }
                        catch (IndexOutOfRangeException) { }

                        try
                        {
                            if (array[i, j - 1] == 8) array[i, j]++;
                        }
                        catch (IndexOutOfRangeException) { }

                        try
                        {
                            if (array[i - 1, j - 1] == 8) array[i, j]++;
                        }
                        catch (IndexOutOfRangeException) { }
                    }
                    
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }

        }
    }
}
