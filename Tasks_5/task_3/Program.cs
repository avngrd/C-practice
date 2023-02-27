namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int numberS;
            int numberC;

            DigitCountSum(out numberC, out numberS);

            Console.WriteLine($"Количество цифр введенного числа:{numberC} ");
            Console.WriteLine($"Сумма цифр введенного числа:{numberS} ");
        }

        public static void DigitCountSum( out int c, out int s)
        {
            s = 0;
            c = 0;

            try
            {
                Console.WriteLine("Введите число k:");
                int k = Convert.ToInt32(Console.ReadLine());

                int firstNumber = k;

                while (k > 0)
                {
                    c++;
                    k /= 10;
                }

                while (firstNumber > 0)
                {
                    s += firstNumber % 10;
                    firstNumber /= 10;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка деления на ноль");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата");
            }
        }
    }
}