using static System.Console;
namespace MyNamespace
{
    
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число а");
            Console.WriteLine("Введите число а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b") ;
            int b = Convert.ToInt32(Console.ReadLine());
            int x = a / 2 + b / 2;
int zzz = 1;
            Console.WriteLine(string.Format("{0:F3}", x));
        }
    }
}
