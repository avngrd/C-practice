namespace MyNameSpace
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Введите M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            double A = 1/2;
            double B = 0;
            double H = (B - A) / M;
            double x = 0;
            x = x + H;
            for (int i = 1; i <= M; i++)
            {
                double y = Math.Cos(Math.Pow(2,x));
                Console.WriteLine($"{i} - {y}");
                x = x + H;
            }
            Console.ReadLine();
        }
    }
}