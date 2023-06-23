using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string elapsedTime;
            Stopwatch stopwatch = new Stopwatch();
            //засекаем время начала операции
            stopwatch.Start();
            ///Фунция
            Collatz(19);
            //
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            // Создаем строку, содержащую время выполнения операции.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine(elapsedTime);
        }

        public static void Collatz(int n)
        {
            int count = 0;
            Console.Write(n);
            while (n != 1)
            {
                if ((n % 2) == 0)
                {
                    n = (n / 2);
                    count++;
                    Console.Write("->" + n);
                }
                else
                {
                    n = 3 * n + 1;
                    count++;
                    Console.Write("->" + n);
                }
            }
            Console.WriteLine(" Длина последовательности: " + count);
        }
    }
}
