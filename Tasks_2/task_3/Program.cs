using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите номер вагона(1-17):");
            int numberOfTrain = Convert.ToInt32(Console.ReadLine());
            if (numberOfTrain >= 10 && numberOfTrain <=17) {
                Console.WriteLine("Вагон купейный");
            }
            else if(numberOfTrain >= 17 || numberOfTrain <= 0)
            {
                Console.WriteLine("Такого вагона не существует");
            }
            else
            {
                Console.WriteLine("Вагон плацкартный");
            }
        }
    }
}