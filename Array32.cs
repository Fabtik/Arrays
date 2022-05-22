using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Array
{
    class Array32
    {
        public static void main()
        {
            int d = 0, m = 0, y = 0;
            bool x = false;

            try
            {
                int[] arr = new int[3];
                arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                d = arr[0];
                m = arr[1];
                y = arr[2];
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            d = d + 2;
            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
            {
                x = true;
            }
            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10)
            {
                if (d > 31)
                {
                    d = d % 31;
                    m++;
                }
            }
            else if (m == 2)
            {
                if (x)
                {
                    if (d > 29)
                    {
                        d = d % 29;
                        m++;
                    }
                }
                else
                {
                    if (d > 28)
                    {
                        d = d % 28;
                        m++;
                    }
                }
            }
            else if (m == 12)
            {
                if (d > 31)
                {
                    d = d % 31;
                    m = 1;
                    y++;
                }
            }
            else
            {
                if (d > 30)
                {
                    d = d % 30;
                    m++;
                }
            }

            Console.WriteLine(d + " " + m + " " + y);
        }
    }
}
