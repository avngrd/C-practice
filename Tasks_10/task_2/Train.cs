namespace task_2
{
    internal class Train
    {
        string targetPoint;
        int trainNumber;
        TimeOnly startRaceTime;

        public int TrainNumber => trainNumber;
        public TimeOnly StartRaceTime => startRaceTime;
        public string TargetPoint => targetPoint;

        public Train(string targetPoint, int trainNumber, TimeOnly startRaceTime)
        {
            this.targetPoint = targetPoint;
            this.trainNumber = trainNumber;
            this.startRaceTime = startRaceTime;
        }

        public override string ToString()
        {
            return $"Пункт назначения:{targetPoint}, номер поезда:{trainNumber},время отправления:{startRaceTime}";
        }
    }
}
