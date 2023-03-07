namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число х: ");
            int xNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число y: ");
            int yNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Сумма, 2 - Разность, 3 - Умножение, 4 - Деление");
            int chooseOperation = Convert.ToInt32(Console.ReadLine());
            int result;

            switch (chooseOperation)
            {
                case 1:
                    Operation sum = Add;
                    result = sum(xNumber,yNumber);
                    Console.WriteLine(result);
                    break;
                case 2:
                    Operation sub = Sub;
                    result = sub(xNumber, yNumber);
                    Console.WriteLine(result);
                    break;
                case 3:
                    Operation mul = Mul;
                    result = mul(xNumber, yNumber);
                    Console.WriteLine(result);
                    break;
                case 4:
                    Operation div = Div;
                    result = Div(xNumber, yNumber);
                    Console.WriteLine(result);
                    break;
            }
        }

        delegate int Operation(int x, int y);

        public static int Add(int xNumber, int yNumber) => xNumber + yNumber;
        public static int Sub(int xNumber, int yNumber) => xNumber - yNumber;
        public static int Mul(int xNumber, int yNumber) => xNumber * yNumber;
        public static int Div(int xNumber, int yNumber) {
            if (xNumber == 0)
            {
                throw new DivideByZeroException();
                Console.WriteLine("Ошибка деления на ноль");
            }
            else if (yNumber == 0)
            {
                throw new DivideByZeroException();
                Console.WriteLine("Ошибка деления на ноль");
            }
            else
            {
                return xNumber / yNumber;
            }
        }
    }
}