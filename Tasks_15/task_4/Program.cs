using System.Threading;
using System.Diagnostics;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int[] numbersArray = { 1, 2, 3, 4, 5 };

            int sum = 0;

            int threadCount = 2;

            int firstIndex = 0;
            int lastIndex = (numbersArray.Length / 2) - 1;

            for (int i = 0; i < threadCount; i++)
            {
                int num = 5 / threadCount;
                Thread thread1 = new Thread(() => { MainThread(firstIndex, lastIndex, numbersArray, out sum); });
                thread1.Start();

                firstIndex = i * num;
                lastIndex = (i + 1) * num - 1;

                if(firstIndex == lastIndex)
                {
                    lastIndex = numbersArray.Length - 1;
                }
                else
                {
                    lastIndex = (i + 1) * num - 1;
                }
            }
            Console.WriteLine(sum);
        }
        static void MainThread(int firstIndex, int lastIndex, int[] numbers, out int sum) 
        {
            int temp = 0;
            for(int i = firstIndex; i <= lastIndex; i++)
            {
                temp+= numbers[i];
            }
            sum = temp;
        }
    }
}