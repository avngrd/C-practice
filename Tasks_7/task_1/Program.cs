namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите сообщение: ");
            string message = Console.ReadLine();

            var symbolToDelete = "а".ToLower();

            var words = message.Split(' ')
                                  .Where(a => !a.ToLower().Contains(symbolToDelete));

            var res = String.Join(" ", words);
            Console.WriteLine(res);
        }
    }
}