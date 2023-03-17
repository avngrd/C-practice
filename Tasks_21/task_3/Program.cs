namespace MyNamespace
{
    class Program
    {

        static int Calculation(int number)
        {
            return (number / 100 + (number%10) % 10 + number % 10);
        }

        public static void Main()
        {
            int numberN;
            Console.WriteLine("Введите число n");
            numberN = Convert.ToInt32(Console.ReadLine());

            Task task1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Первая задача началась");
                Task<int> task2 = Task<int>.Factory.StartNew(() =>
                {
                    Console.WriteLine("Вторая задача началась");
                    return Calculation(numberN);
                });
                task2.Wait();
                Console.WriteLine("Вторая задача завершилась");
                Console.WriteLine(task2.Result);
            });
            task1.Wait();
            Console.WriteLine("Первая задача завершилась");
            Console.ReadLine();
        }
    }
}