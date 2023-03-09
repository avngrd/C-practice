namespace MyNamespace
{
    class Program
    {
         delegate int Operation(int x, int y);

        public static void Main()
        {
            Console.WriteLine("Введите номер операции которую хотите выбрать(1 - сумма, 2 - вычитание, 3 - умножение)");
            int chosenOperation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число а:");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int numberB = Convert.ToInt32(Console.ReadLine());
            int result;
            switch (chosenOperation)
            {
                case 1:
                    Operation operation = Add;
                    result = operation(numberA, numberB);
                    Console.WriteLine(result);
                    break;
                case 2:
                    Operation operation1 = Subtraction;
                    result = operation1(numberA,numberB);
                    Console.WriteLine(result);
                    break;
                case 3:
                    Operation operation2 = Diversion;
                    result = operation2(numberA, numberB);
                    Console.WriteLine(result);
                    break;
                default:Console.WriteLine("Такой операции нет");break;

            }
        }

        public static int Add(int numberA, int numberB)
        {
            Console.WriteLine("Операция сложения");
            int result = numberA + numberB;

            return result;
        }
        public static int Subtraction(int numberA, int numberB)
        {
            Console.WriteLine("Операция вычитания");
            int result = numberA - numberB;

            return result;
        }
        public static int Diversion(int numberA, int numberB)
        {
            Console.WriteLine("Операция деления");
            int result = numberA / numberB;

            return result;
        }
    }
}