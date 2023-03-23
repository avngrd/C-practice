using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            double a, b, c, d, e, f, g;

            WriteLine("Введите сторону А:");
            a = Convert.ToDouble(Console.ReadLine());

            WriteLine("Введите сторону B:");
            b = Convert.ToDouble(Console.ReadLine());

            WriteLine("Введите сторону C:");
            c = Convert.ToDouble(Console.ReadLine());

            WriteLine("Введите сторону D:");
            d = Convert.ToDouble(Console.ReadLine());

            WriteLine("Введите сторону E:");
            e = Convert.ToDouble(Console.ReadLine());

            WriteLine("Введите сторону F:");
            f = Convert.ToDouble(Console.ReadLine());

            WriteLine("Введите сторону G:");
            g = Convert.ToDouble(Console.ReadLine());

            double nums, ans_2;

            Triangle(f, g, c, out double ans_1);

            Console.WriteLine(ans_1);

            Triangle(a, b, f, out nums);

            Console.WriteLine(nums);

            Triangle(e, g, d, out ans_2);
            var square = nums + ans_1 + ans_2;

            Console.WriteLine(ans_2);
            Console.WriteLine(square);
        }
        static void Triangle(double x, double y, double z, out double square)
        {
            square = 0;
            double p = (x + y + z) / 2.0;

            double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));

            square += Convert.ToDouble(s);
        }
        static double Triangle(double x, double y, double z, double w, double j)
        {
            double p = (x + y + z + w + j) / 2.0;

            double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z) * (p - w) * (p - j));

            return s;
        }
    }
}
