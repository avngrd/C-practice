using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите скорость в стоячей воде:");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скорость течения реки:");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите время движения по озеру:");
            int t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите время движения против течения:");
            int t2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Путь пройденный по озеру:{v * t1} км") ;
            Console.WriteLine($"Весь путь составит:{v * t1 + t2 * (v - v1)} км");
        }
    }
}