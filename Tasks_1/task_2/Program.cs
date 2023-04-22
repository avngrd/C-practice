using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число 4х значное число");
            int number = Convert.ToInt32(Console.ReadLine());
            int numberOne = number / 1000;
            int numberTwo = (number % 1000) / 100;
            Console.WriteLine($"Получившееся число:{numberTwo}{numberOne}");
            
            
            
        }
    }
}
