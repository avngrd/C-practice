using task_1;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Product marker = new Marker("Red",1,10,10);
            decimal markerPrice = marker.Price();

            Console.WriteLine(markerPrice);
        }
    }
}