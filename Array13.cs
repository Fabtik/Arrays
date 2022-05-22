using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array13
    {
        public static void main()
        {
            int[] input = new int[5]; // N = 0, A = 1, B = 2, C = 3, D = 4;
            try
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int[] array = new int[input[0]];


            array[0] = 1;
            int k = 1;
            for (int i = input[2]; i >= input[1]; i--)
            {
                array[k] = i;
                k++;
            }
            for (int i = input[4]; i >= input[3]; i--)
            {
                array[k] = i;
                k++;
            }

            for(int i = 0; i < input[0]; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
