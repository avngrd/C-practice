using System.Text.RegularExpressions;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            var data = new string[]
            {
                "+71783192919",
                "serega@mail.ru",
                "+12345678999",
                "bobmarleys@yahoo.com",
                "+13435465566",
                "sam@yandex.ru",
                "+43743989393",
                "grodnonews@gmail.ru",
                "+78333669991",
                "salesmanager@yandex.ru",
                "+11012391393",
                "alexmaliks@mail.ru",
                "+9999123189393",
            };

            Console.WriteLine("Email List");
            for (int i = 0; i < data.Length; i++)
            {
                if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine(data[i]);
                }
            }
        }
    }
}