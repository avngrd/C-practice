using task_2;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            MyDictionary<string, int> list = new MyDictionary<string, int>();
            list.Add("key1", 9065);
            list.Add("key5?", 23423);
            list.Add("key3", 112301);
            list.Add("key14", 50120);
            Console.WriteLine("Элемент с ключем 'key14': " + list["key14"]);
            Console.WriteLine("Количество пар: " + list.Length);
        }
    }
}