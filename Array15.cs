using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array15
    {
        public static void main()
        {
            int N = 0, counter = 0, temp = 0, tempCounter = 1;

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

            temp = array[0];
            for (int i = 1; i < N; i++)
            {
                if (array[i] != temp)
                {
                    temp = array[i];
                    if(tempCounter >= 3)
                    {
                        counter += tempCounter;
                    }
                    tempCounter = 1;
                    
                }
                else
                {
                    tempCounter++;
                }
            }

            if (tempCounter >= 3)
            {
                counter += tempCounter;
            }

            Console.WriteLine(counter);
        }
    }
}
