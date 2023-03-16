using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int a, b, c, d, e, f, g;

            WriteLine("Введите сторону А:");
            a = Convert.ToInt32(Console.ReadLine());

            WriteLine("Введите сторону B:");
            b = Convert.ToInt32(Console.ReadLine());

            WriteLine("Введите сторону C:");
            c = Convert.ToInt32(Console.ReadLine());

            WriteLine("Введите сторону D:");
            d = Convert.ToInt32(Console.ReadLine());

            WriteLine("Введите сторону E:");
            e = Convert.ToInt32(Console.ReadLine());

            WriteLine("Введите сторону F:");
            f = Convert.ToInt32(Console.ReadLine());

            WriteLine("Введите сторону G:");
            g = Convert.ToInt32(Console.ReadLine());

            int nums, ans_2;

            Triangle(f, g, c, out int ans_1);

            Console.WriteLine(ans_1);

            Triangle(a, b, f, out nums);

            Console.WriteLine(nums);

            Triangle(e, g, d, out ans_2);
            var square = nums + ans_1 + ans_2;

            Console.WriteLine(ans_2);
            Console.WriteLine(square);
        }

        /// <summary>
        /// Method calculates
        /// </summary>
        /// <param name="x">x side value</param>
        /// <param name="y">y side value</param>
        /// <param name="z">z side value</param>
        /// <returns>
        /// <param name="square">return out param square </param>
        /// </returns>

        static void Triangle(int x, int y, int z, out int square)
        {
            square = 0;
            double p = (x + y + z) / 2.0;

            double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));

            square += Convert.ToInt32(s);
        }

        /// <summary>
        /// Method overload
        /// </summary>
        /// <param name="x">x side value</param>
        /// <param name="y">y side value</param>
        /// <param name="z">z side value</param>
        /// <param name="w">w side value</param>
        /// <param name="j">j side value</param>
        /// <returns>
        /// square of triangle
        /// </returns>

        static double Triangle(int x, int y, int z, int w, int j)
        {
            double p = (x + y + z + w + j) / 2.0;

            double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z) * (p - w) * (p - j));

            return s;
        }
    }
}