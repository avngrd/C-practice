using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(FirstThread));

            thread1.Start();
            thread1.Join();
            thread2.Start();
            thread2.Join();
        }

        static void FirstThread()
        {
            var sWatch = new Stopwatch();
            sWatch.Start();
            int temp = 0;
            Console.WriteLine("Поток запущен");
            for (int i = 0; i <= 9; i++)
            {
                temp += i;
            }
            Console.WriteLine(temp);
            sWatch.Stop();
            Console.WriteLine($"{sWatch.ElapsedMilliseconds.ToString()} - мс затрачено");
        }
    }
}