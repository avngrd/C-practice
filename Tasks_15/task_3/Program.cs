using System.Threading;
using System.Diagnostics;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {

            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(FirstThread));
            Thread thread3 = new Thread(new ThreadStart(SecondThread));

            thread1.Start();
            thread1.Join();
            thread2.Start();
            thread2.Join();
            thread3.Start();
        }

        static void FirstThread()
        {
            Console.WriteLine("Введите число А:");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N:");
            int numberN= Convert.ToInt32(Console.ReadLine());

            int temp = 0;
            Console.WriteLine("Поток запущен");
            for (int i = numberA; i <= numberN; i++)
            {
                temp += Convert.ToInt32(Math.Pow(numberA,numberN));
            }
            Console.WriteLine(temp);
        }

        static void SecondThread()
        {
            Console.WriteLine("Введите число А:");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N:");
            int numberN = Convert.ToInt32(Console.ReadLine());

            int temp = 1;
            Console.WriteLine("Поток 2 запущен");
            for (int i = numberA; i <= numberN; i++)
            {
                temp += temp * Convert.ToInt32(Math.Pow(numberA, numberN));
            }
            Console.WriteLine(temp);
        }
    }
}