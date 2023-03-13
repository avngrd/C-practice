namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            FileStream file = new FileStream(@"g.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string line;
            int n = 0;
            int countOfNumbers = 0;
            while ((line = reader.ReadLine()) != null)
            {
                n++;
            }
            reader.Close();

            int[] numbersArray = new int[n];
            FileStream file1 = new FileStream(@"g.txt", FileMode.Open);
            StreamReader reader1 = new StreamReader(file1);
            for(int i = 0; i < n; i++)
            {
                numbersArray[i] = Convert.ToInt32(reader1.ReadLine());
                if(numbersArray[i] % 2 == 0)
                {
                    countOfNumbers++;
                }
            }
            Console.WriteLine($"Количество четных чисел - {countOfNumbers}");
        }
    }
}