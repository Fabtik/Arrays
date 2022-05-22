using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Array33
    {
        public static void main()
        {
            int d = 0, N = 0;
            DateTime StartDate = new DateTime(1, 1, 1);

            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }
            DateTime Date = new DateTime(N % 10000, (N / 10000) % 100, N / 1000000);
           
            Console.WriteLine(Date.Subtract(StartDate).Days);
        }
    }
}
