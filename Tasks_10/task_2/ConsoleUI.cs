using task_2;

namespace MyNamespace
{
    internal class ConsoleUI
    {
        internal static void Show(IEnumerable<Train> trains)
        {
            foreach (Train train in trains)
            {
                Console.WriteLine(train);
            }
        }

        internal static void Show(Train trainByPoint)
        {
            Console.WriteLine(trainByPoint);
        }

        //internal static void Show(List<Train> trains)
        //{
        //    foreach (Train train in trains)
        //    {
        //        Console.WriteLine(train);
        //    }
        //}
    }
}