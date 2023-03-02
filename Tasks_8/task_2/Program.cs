using System.Text.RegularExpressions;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            string message = 
                "<div className=\"cart cart--empty\">\r\n" +
                    "<h2>\r\n" +
                        "Корзина пустая <span>😕</span>\r\n" +
                    "</h2>\r\n" +
                    "<p>\r\n" +
                        "Вероятней всего, вы не заказывали ещё пиццу.\r\n" +
                        "<br />\r\n" +
                        "Для того, чтобы заказать пиццу, перейди на главную страницу.\r\n" +
                   "</p>\r\n" +
                        "<img src={cartEmptyImg} alt=\"Empty cart\" />\r\n" +
                    "<Link to=\"/\" className=\"button button--black\">\r\n" +
                        "<span>Вернуться назад</span>\r\n" +
                    "</Link>\r\n" +
                "</div>";
            Regex regex = new Regex(@"<[^>]*>");
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