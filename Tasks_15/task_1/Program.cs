using System.Threading;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            Thread thread3 = new Thread(new ThreadStart(ThirdThread));

            thread1.Start();
            thread1.Join();
            thread2.Start();
            thread2.Join();
            thread3.Start();
            thread3.Join();
        }

        static void FirstThread(){
            Console.WriteLine("Первый поток");
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine(i);
            }
        }
        static void SecondThread()
        {
            Console.WriteLine("Второй поток");
            for (int i = 10; i <= 19; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void ThirdThread()
        {
            Console.WriteLine("Третий поток");
            for (int i = 20; i <= 29; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}