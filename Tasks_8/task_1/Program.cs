using System.Text.RegularExpressions;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            string message = "У меня хорошее настроение я кушал вкусное и крутое печенье, оно было классное";
            Regex regex = new Regex(@"\w*ое\w*");
            MatchCollection matches = regex.Matches(message);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}