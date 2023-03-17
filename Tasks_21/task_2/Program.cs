using static System.Math;

namespace MyNameSpace
{
    class Program
    {
        static double firstExpression(double a, double b)
        {
            return (Sin(2 * a) + Sin(5 * a) - Sin(3 * a)) / Cos(a) + 1 - 2 * Pow(Sin(2 * a), 2);
        }
        static double secondExpression(double b)
        {
            return 2 * Sin(b);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Task[] tasks = new Task[2]
            {
                new Task(() => Console.WriteLine($"1 задача: {firstExpression(a, b)}")),
                new Task(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"2 задача: {secondExpression(b)}");
                })
            };
            foreach (var task in tasks)
            {
                task.Start();
                task.Wait();
            }
        }
    }
}