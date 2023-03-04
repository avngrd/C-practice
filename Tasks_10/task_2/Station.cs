using System.Transactions;

namespace task_2
{
    internal class Station
    {
        Train[] _trains;

        internal bool CompareTime(TimeOnly startRaceTime1, TimeOnly startRaceTime2)
        {
            return startRaceTime1 == startRaceTime2;
        }

        internal Train GetByIndex(int index)
        {
            if(index >= _trains.Length || index < 0)
            {
                throw new ArgumentException(nameof(index));
            }

            return _trains[index];  
        }

        internal Train GetByNumber(int firstTrainNumber)
        {
            return _trains.FirstOrDefault(t => t.TrainNumber == firstTrainNumber);
        }

        internal Train GetByPoint(string? enteredPoint)
        {
            return _trains.FirstOrDefault(t => t.TargetPoint == enteredPoint );
        }

        internal IEnumerable<Train> GetByTime(TimeOnly currentTime)
        {
            List<Train> trains = new List<Train>();

            foreach(Train train in _trains)
            {
                if (currentTime < train.StartRaceTime) { 
                    trains.Add(train);
                }
            }
            return trains;
        }

        internal Train[] GetTrain()
        {
            _trains = new Train[]
            {
                new Train("Grodno",1,new TimeOnly(10,30)),
                new Train("Minsk",14,new TimeOnly(12,55)),
                new Train("Brest",6,new TimeOnly(7,00)),
                new Train("Mogilev",18,new TimeOnly(19,01)),
                new Train("Moscow",9,new TimeOnly(22,30)),
                new Train("Vitebsk",20,new TimeOnly(5,20)),

            };
            return _trains;
        }
    }
}
