using task_3;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Пример: ");
            Animals dem = new Animals("Сибирский тигр", 2034);
            InfoObj.Info<Animals>(dem);
            Pl plan_list = new Pl();
            Dictionary<int, string> hike = new Dictionary<int, string>(3);
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите имя животного: ");
                string w = null;
                w = Console.ReadLine();
                Console.Write("Введите сколько их осталось на земле: ");
                int g = Convert.ToInt32(Console.ReadLine());

                plan_list.Add(new Animals(w, g));
                hike[i + 1] = w;
            }
            Console.WriteLine("============ ");
            foreach (KeyValuePair<int, string> keyValue in hike)
            {
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
            }
            Console.WriteLine("============ ");
            foreach (Animals x in plan_list)
                x.PrintInfoAboutAnimal();
            plan_list.RemoveAt(1);
            Console.WriteLine("============ ");
            Pl pl = (Pl)plan_list.Clone();
            foreach (Animals x in pl) x.PrintInfoAboutAnimal();
            Console.ReadLine();
        }
    }
}