namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите сообщение: ");
            string message = Console.ReadLine();
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Перевести текст в нижний регистр, 2 - Перевести текст в верхний регистр, 3 - Умножение");
            int chooseOperation = Convert.ToInt32(Console.ReadLine());
            string result;

            switch (chooseOperation)
            {
                case 1:
                    StringOperation lower = toLowerRegister;
                    result = lower(message);
                    Console.WriteLine(result);
                    break;
                case 2:
                    StringOperation upper = toUpperRegister;
                    result = upper(message);
                    Console.WriteLine(result);
                    break;
                case 3:
                    StringOperation replace = ReplaceString;
                    result = replace(message);
                    Console.WriteLine(result);
                    break;
            }
        }
        delegate string StringOperation(string message);

        public static string toLowerRegister(string message)
        {
            if (message == message.ToLower()) {
                Console.WriteLine("Строка уже в нижнем регистре!");
                return message;
            }
            else
            {
                return message.ToLower();
            } 
        }

        public static string toUpperRegister(string message)
        {
            if (message == message.ToUpper())
            {
                Console.WriteLine("Строка уже в верхнем регистре!");
                return message;
            }
            else
            {
                return message.ToUpper();
            }
            
        }
        public static string ReplaceString(string message)
        {
            Console.WriteLine("Введите строку которую хотите изменить в сообщении: ");
            string replaceMessage = Console.ReadLine();
            Console.WriteLine("Введите строку на которую хотите изменить: ");
            string enteredString = Console.ReadLine();
            message = message.Replace(replaceMessage, enteredString);

            return message;
        }
    }
}