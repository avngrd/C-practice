using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int lengthCountry;
            WriteLine("Введите длину пути");
            lengthCountry = Convert.ToInt32(Console.ReadLine());
            double gasoline;
            WriteLine("Введите расход");
            gasoline = Convert.ToDouble(Console.ReadLine());
            double gasPrice;
            WriteLine("Введите цену бензина");
            gasPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Цена " + ((gasoline / 100) * (lengthCountry * 2)) * gasPrice);
            Console.ReadLine();
        }
    }
}