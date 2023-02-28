namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            string message = "Введите число n: ";
            int number = Input(message);

            int checkedNumber = Recursion(number);
            Console.WriteLine(checkedNumber);

        }

        static int Recursion(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else
            {
                n = Factorial(n - 3)/Factorial(n - 4);
                return n;
            }
        }

        public static int Input(string message)
        {
            int number = 0;
            do { 
                Console.WriteLine(message);
                number = int.Parse(Console.ReadLine());
            
            } while (number < 4);
            return number;
        }

        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }
}