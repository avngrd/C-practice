using task_3;

namespace MyNameSpace { 
class Program
{
    static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>();
        list.Add(23);
        list.Add(41);
        list.Add(89);
        Console.WriteLine($"Элемент с индексом 1: {list[1]}");
        Console.WriteLine($"Длина: {list.Length}");
        list.GetArray();
    }
}
}