namespace SD340_Lab2.Models
{
    public class ScheduleStop
    {
        public int Id { get; set; }
        public Stop Stop { get; set; }
        public Route Route { get; set; }
        public DateTime ScheduledArrival { get; set; }
    }
}
