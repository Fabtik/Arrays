using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Array
{
    class Array12
    {
        public static void main()
        {
            int N = 0, Petro = 0, position = 1;

            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int[] array = new int[N];
            try
            {
                array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            try
            {
                Petro = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            for (int i = 0; i < N; i++)
            {
                if (Petro > array[i])
                {
                    break;
                }
                else position++;
            }

            Console.WriteLine(position);
        }
    }
}
