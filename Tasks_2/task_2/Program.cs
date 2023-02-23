using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите трехзначное число:");
            int number = Convert.ToInt32(Console.ReadLine());

            int a = number / 100;

            int b = number % 10;

            if (a > b) {
                Console.WriteLine($"Первая цифра больше третьей: {a} > {b} "); ;
            }else if ( a < b)
            {
                Console.WriteLine($"Третья цифра больше первой: {a} < {b}");
            }
            else
            {
                Console.WriteLine($"Цифры равны: {a} == {b}");
            }

        }
    }
}