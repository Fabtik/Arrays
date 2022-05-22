using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array11
    {
        public static void main()
        {
            int N = 0, counter = 1;
            bool isUnique = true;

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


            for (int i = 0; i < N; i++)
            {
                isUnique = true;
                for(int j = 0; j < N; j++)
                {
                    if (j != i)
                    {
                        if(array[i] == array[j])
                        {
                            isUnique = false;
                        }
                    }
                }
                if (isUnique) counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
