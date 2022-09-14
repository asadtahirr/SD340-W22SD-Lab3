namespace SD340_Lab2.Models
{
    public class Route
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public bool RampAccessible { get; set; }
        public bool BicycleAccessible { get; set; }
        public Queue<ScheduleStop> StopSchedule { get; set; }

    }
}
