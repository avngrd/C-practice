using System.Text;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите сообщение: ");
            string message = Console.ReadLine();

            string[] words = message.Split(new char[] { ' ' });

            string firstWord = words[0].Substring(2);

            Console.WriteLine(words[words.Length - 1] + " " + $"{words[1] + ReverseString(words[2])} " + firstWord);
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}