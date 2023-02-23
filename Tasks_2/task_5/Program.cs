using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число n");
            int number = Convert.ToInt32(Console.ReadLine());
            double temp = 0;
            for (int i = 1; i <= number; i++)
                temp += 1.0 / i;
            Console.WriteLine($" {temp}");
            Console.ReadKey(true);
        }
    }
}