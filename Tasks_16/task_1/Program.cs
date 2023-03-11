using task_1;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            MyList<int> mylist = new MyList<int>(5);
            mylist[0] = 1;
            Console.WriteLine("Количество элементов: {0}", mylist.Size);
            mylist.Add(19);
            Console.WriteLine(" Количество элементов: {0}", mylist.Size);
            Console.WriteLine("Введите индекс элемента который хотите получить:");
            int enteredElement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Полученный элемент: {mylist[enteredElement]}");

            for (int i = 0; i < mylist.Size ; i++)
            {
                Console.WriteLine(mylist[i]);
            }    

            Console.ReadKey();
        }
    }
}