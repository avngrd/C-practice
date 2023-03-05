using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;
            double xqwe;
            double e = 2.7;
            if (x > 2) {
                y = Math.Pow(3, x) * Math.Sqrt(x-2);
                Console.WriteLine($"Значение y:{y}");
            }
            else if(x == 2)
            {
                y = Math.Sin(2 * x);
                Console.WriteLine($"Значение y:{y}");
            }
            else if (x < 2) {
                y = Math.Pow(-2 * x, e) * Math.Cos(2 * x);
                Console.WriteLine($"Значение y:{y}");
            };
        }
    }
}