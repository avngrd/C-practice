namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("Введите число x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int result;

            try
            {
                if(x < 1 && x > -1)
                {
                    result = x + 14;
                    Console.WriteLine($"Результат:{result}");
                }else if ( x >= 1 && x <= 100)
                {
                    result = (x - 1) / (x - 4);
                    Console.WriteLine($"Результат:{result}");
                }else
                {
                    throw new Exception("Выход за диапазон");
                }
            }
            catch(DivideByZeroException)
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