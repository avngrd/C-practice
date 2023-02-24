using System.Security.Cryptography.X509Certificates;
using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            MathExpresion first = new MathExpresion();

            first.ExpressionCalc();

            MathExpresion second = new MathExpresion();

            second.DegreeCalc();

        }
    }

    class MathExpresion
    {
        public int a;
        public int b;
        public int number;
    
        public void ExpressionCalc()
        {
            Console.WriteLine("Введите число а:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" Результат вычисления: { (4/(a+2)) * b}");
        }

        public void DegreeCalc()
        {
            Console.WriteLine("Введите число для возведения в 10 степень: ");
            number = Convert.ToInt32(Console.ReadLine());
     
            Console.WriteLine($"Результат: {Math.Pow(number, 10)}");
        }

    }
}