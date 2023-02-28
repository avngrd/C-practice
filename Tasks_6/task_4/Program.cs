namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int[] numbersArray = Input();
            Console.WriteLine("Исходный массив");
            Print(numbersArray);
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
            int averageNumber = 0;
            int temp = 0;
            int numberCheck = 0;
            int[] checkedNumbers; 

            for (int i = 0; i < a.Length; i++)
            {
                averageNumber += a[i];
            }

            temp = averageNumber / a.Length;

            Console.WriteLine("Среднее число элементов массива: " + temp);

            int minNumber = Math.Abs(temp - a[0]);

            int indexMinNumber = 0;

            for (int i = 1; i < a.Length; i++) {
                numberCheck = temp - a[i];

                if (numberCheck < minNumber) { 
                    minNumber = numberCheck;
                    indexMinNumber = i;
                }
            }
            Console.WriteLine("Индекс ближайшего числа к среднему: "+ indexMinNumber);
        }
    }
}