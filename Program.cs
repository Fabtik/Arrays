using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Одномірні та багатовимірні матриці");
            Console.WriteLine("Select");
            int n = 1;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            switch (n)
            {
                case 1:
                    Array1.main();
                    break;
                case 2:
                    Array2.main();
                    break;
                case 3:
                    Array3.main();
                    break;
                case 4:
                    Array4.main();
                    break;
                case 5:
                    Array5.main();
                    break;
                case 6:
                    Array6.main();
                    break;
                case 7:
                    Array7.main();
                    break;
                case 8:
                    Array8.main();
                    break;
                case 9:
                    Array9.main();
                    break;
                case 10:
                    Array10.main();
                    break;
                case 11:
                    Array11.main();
                    break;
                case 12:
                    Array12.main();
                    break;
                case 13:
                    Array13.main();
                    break;
                case 14:
                    Array14.main();
                    break;
                case 15:
                    Array15.main();
                    break;
                case 16:
                    Array16.main();
                    break;
                case 17:
                    Array17.main();
                    break;
                case 18:
                    Array18.main();
                    break;
                case 19:
                    Array19.main();
                    break;
                case 20:
                    Array20.main();
                    break;
                case 21:
                    Array21.main();
                    break;
                case 22:
                    Array22.main();
                    break;
                case 23:
                    Array23.main();
                    break;
                case 24:
                    Array24.main();
                    break;
                case 25:
                    Array25.main();
                    break;
                case 26:
                    Array26.main();
                    break;
                case 27:
                    Array27.main();
                    break;
                case 29:
                    Array29.main();
                    break;
                case 30:
                    Array30.main();
                    break;
                case 31:
                    Array31.main();
                    break;
                case 32:
                    Array32.main();
                    break;
                case 33:
                    Array33.main();
                    break;



                default:
                    Console.WriteLine("Out of Range");
                    break;
            }
        }
    }
}
