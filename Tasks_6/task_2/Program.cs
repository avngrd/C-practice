namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int[] numbersArray = Input();
            Console.WriteLine("Исходный массив");
            Print(numbersArray);
            Console.WriteLine("Измененный массив");
            Change(numbersArray);
        }
        static int[] Input()
        {
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}", a[i]);
                Console.WriteLine();
            }
        }
        static void Change(int[] a)
        {
            int countOfNumbers = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    countOfNumbers++;
                    Console.Write("{0}", a[i]);
                    Console.WriteLine();
                    
                }
            }
            Console.WriteLine($"Количество нечетных чисел: {countOfNumbers}");
        }
    }
}