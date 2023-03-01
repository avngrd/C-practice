using System.Text;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            string message = "Пришла весная у всех хорошее настроение";

            StringBuilder sb = new StringBuilder();
            foreach (string word in message.Split(' '))
            {
                sb.Append(word[word.Length - 1]);
            }
            Console.WriteLine(sb.ToString());
        }
    }

}