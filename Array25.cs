using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array25
    {
        public static void main()
        {
            int N = 0;
            char direction = 'w'; // w - up, a - left, s - down, d - right

            try
            {
                N = Convert.ToInt32(Console.ReadLine());

            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int arrSize = 2 * N + 1;
            int[,] array = new int[arrSize, arrSize];

            int i = N;
            int j = N;
            int k = 0;
            int c = 1;
            while (k < arrSize * arrSize)
            {
                if (direction == 'w')
                {
                   
                    for (int q = 0; q < c; q++)
                    {
                        
                        try
                        {
                            array[i, j] = k;
                            k++;
                            i--;
                        }
                        catch (System.IndexOutOfRangeException)
                        {

                        }
                    }
                    
                    direction = 'a';
                }
                if(direction == 'a')
                {
                    for (int q = 0; q < c; q++)
                    {
                        try
                        {
                            array[i, j] = k;
                            k++;
                            j--;
                        }
                        catch (System.IndexOutOfRangeException)
                        {

                        }
                    } 
                   
                    direction = 's';
                    c++;
                }
                if(direction == 's')
                {
                   
                    for (int q = 0; q < c; q++)
                    {
                        try
                        {
                            array[i, j] = k;
                            k++;
                            i++;
                        }
                        catch (System.IndexOutOfRangeException)
                        {

                        }                                              
                    }
                    direction = 'd';
                }
                if(direction == 'd')
                {
                    
                    for (int q = 0; q < c; q++)
                    {
                        try
                        {
                            array[i, j] = k;
                            k++;
                            j++;
                        }
                        catch (System.IndexOutOfRangeException)
                        {

                        }
                        
                    }
                    direction = 'w';
                    c++;
                }
            }

            ShowArr(array, arrSize);
        }

        public static void ShowArr(int[,] arr, int size)
        {
            Console.Write("\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

    }
}
