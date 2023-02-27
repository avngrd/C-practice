namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int temp;
            Console.WriteLine("Выберите формулу для решения(1,2): ");
            temp = Convert.ToInt32(Console.ReadLine());

            switch (temp) {
                case 1:
                    firstTask();
                    break;
                case 2:
                    secondTask();
                    break;
                default:
                    Console.WriteLine("Неверное значение");
                    break;
            }
        }

        public static void firstTask() {

            try
            {
                int y;

                Console.WriteLine("Введите число x:");
                int x = Convert.ToInt32(Console.ReadLine());

                y = 4 - ((x-7)/(4-x));

                Console.WriteLine($"Результат: {y}");

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Ошибка деления на ноль");
            }
            catch (FormatException) {
                Console.WriteLine("Ошибка формата");
            }
        }
        public static void secondTask()
        {
            try
            {
                double y;

                Console.WriteLine("Введите число x:");
                double x = Convert.ToDouble(Console.ReadLine());

                y = Math.Sin(x)/(Math.Pow(x,3) - 1);

                Console.WriteLine($"Результат: {y}");

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