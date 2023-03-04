using task_2;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Station station = new Station();
            Train[] trains = station.GetTrain();
            ConsoleUI.Show(trains);

            Console.WriteLine("Введите индекс поезда в массиве:");
            int index = Convert.ToInt32(Console.ReadLine());
            var train = station.GetByIndex(index);
            Console.WriteLine(train);

            Console.WriteLine("Введите время с которого будут отправления:");
            TimeOnly currentTime = TimeOnly.Parse(Console.ReadLine());
            var departingTrains = station.GetByTime(currentTime);
            ConsoleUI.Show(departingTrains);

            Console.WriteLine("Введите номер 1-го поезда: ");
            int firstTrainNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер 2-го поезда: ");
            int secondTrainNumber = int.Parse(Console.ReadLine());
            Train firstTrain = station.GetByNumber(firstTrainNumber);
            Train secondTrain = station.GetByNumber(secondTrainNumber);
            bool isTranEqualByTime  =  station.CompareTime(firstTrain.StartRaceTime, secondTrain.StartRaceTime);
            Console.WriteLine($"Поезда отправляются в одно время - {isTranEqualByTime}");

            Console.WriteLine("Введите пункт назначения для получения информации: ");
            string enteredPoint = Console.ReadLine();
            var trainByPoint =  station.GetByPoint(enteredPoint);
            ConsoleUI.Show(trainByPoint);
        }
    }
}