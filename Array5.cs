using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array5
    {
        public static void main()
        {
            int N = 0;
            bool isTwoElementsWithTheSame = false;

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

            for (int i = 1; i < N; i++)
            {
                if (array[i] > 0 && array[i-1] > 0 || array[i] < 0 && array[i-1] < 0)
                {
                    isTwoElementsWithTheSame = true;
                }
            }

            if (isTwoElementsWithTheSame)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
        } 
    }
}
