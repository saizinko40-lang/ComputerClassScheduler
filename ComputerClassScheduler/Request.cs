namespace ComputerClassScheduler.Logic
{
    public class Request
    {
        public int DayOfWeek { get; set; }   // 1 = Monday ... 7 = Sunday
        public int StartHour { get; set; }   // lesson start
        public int EndHour { get; set; }     // lesson end
        public string GroupName { get; set; }
        public int GroupPriority { get; set; }
    }
}