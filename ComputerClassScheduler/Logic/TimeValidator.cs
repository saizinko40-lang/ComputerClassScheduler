namespace ComputerClassScheduler.Logic
{
    public class TimeValidator
    {
        public bool IsWithinWorkingHours(int startHour, int endHour)
        {
            return startHour >= 8 && endHour <= 18 && startHour < endHour;
        }
    }
}