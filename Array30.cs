using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Array30
    {
        public static void main()
        {
            int N = 0;
            char direction = 'a'; // w - up, a - left, s - down, d - right

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
                array[0,i] = 1;
                array[N - 1, i] = 1;
                array[i, N - 1] = 1;
            }


            int h = N - 2, d = N - 2;
            int pointx = N - 1, pointy = 0;
            while (true)
            {
                for (int i = 0; i < h; i++)
                {
                    array[pointx - i, pointy] = 1;
                }
                pointx -= h - 1;
                h -= 2;
                if (h <= 0)
                    break;
                for (int i = 0; i < d; i++)
                {
                    array[pointx, pointy + i] = 1;
                }
                pointy += d - 1;
                d -= 2;
                if (d <= 0)
                    break;
                for (int i = 0; i < h; i++)
                {
                    array[pointx + i,pointy] = 1;
                }
                pointx += h - 1;
                h -= 2;
                if (h <= 0)
                    break;
                for (int i = 0; i < d; i++)
                {
                    array[pointx,pointy - i] = 1;
                }
                pointy -= d - 1;
                d -= 2;
                if (d <= 0)
                    break;
            }
            array[N / 2,N / 2] = 0;

            ShowArr(array, N);
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
