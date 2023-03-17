using System;
using System.Threading.Tasks;

namespace MyNameSpace
{
    class Program
    {
        static int NumberChange(int enteredNumber)
        {
            int firstNumber = enteredNumber / 1000;
            int secondNumber = (enteredNumber % 1000) / 100;
            int thirdNumber = (enteredNumber % 100) / 10;
            int fourthNumber = enteredNumber % 10;

            string fullNumber = Convert.ToString(secondNumber) + Convert.ToString(firstNumber) + Convert.ToString(thirdNumber) + Convert.ToString(fourthNumber);

            Console.WriteLine(fullNumber);
            return Convert.ToInt32(fullNumber);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4 значное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Task task1 = new Task(() => NumberChange(number));
            task1.Start();
            task1.Wait();

            Task task2 = Task.Factory.StartNew(() => NumberChange(number));
            task2.Wait();
            Task task3 = Task.Run(() => NumberChange(number));
            task3.Wait();
        }
    }
}