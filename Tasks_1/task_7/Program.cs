using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());

            double z1 = (Math.Sin(2 * a)+ Math.Sin(5 * a) - Math.Sin(3 * a))/(Math.Cos(a) - Math.Cos(3 * a) + Math.Cos(5 * a));
            double z2 = Math.Atan(3 * a);

            Console.WriteLine($"Число Z1:{z1} Число Z2:{z2}");
        }
    }
}