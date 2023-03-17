using static System.Math;

namespace MyNameSpace
{
    class Program
    {
        static void Func(int x)
        {
            double result = Cos(Pow(x,2));
            Console.WriteLine($"Значение функции Cos(x^2) при x={x} будет равно {Round(result,3)}");
        }

        static void Main(string[] args)
        {
            int firstNumber = -6;

            int secondNumber = 6;

            Parallel.For(firstNumber,secondNumber, Func);
        }
    }
}