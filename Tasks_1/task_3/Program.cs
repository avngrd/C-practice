using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {



          double x = 5.2;
           int y = Convert.ToInt32(Math.Pow(Math.Sin(Math.Pow(x * x + 5,2)),3) - Math.Sqrt(x/4));
            Console.WriteLine(y);
        }
    }
}