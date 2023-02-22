using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
           int n;
            WriteLine("Введите число n");
            n = Convert.ToInt32(Console.ReadLine());

            int a = n / 100; // 1
           
            int c = (n / 10) % 10; // 1.2
           
            int b = (n % 10); // 12.3
  
            Console.ReadLine();

            Console.WriteLine(a + b);
        }
    }
}