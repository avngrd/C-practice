using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            for (int i = 100; i <= 999; i++)
            {
                int number = i;
                int numberOne = number / 100;
                number %= 100;
                int numberTwo = number / 10;
                number %= 10;
                int numberThree = number / 1;
                number %= 1;
                if ((numberOne == numberTwo || numberTwo == numberThree || numberThree == numberOne))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}