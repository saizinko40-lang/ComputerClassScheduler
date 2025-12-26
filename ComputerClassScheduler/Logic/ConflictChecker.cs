using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerClassScheduler.Logic
{
    public class ConflictChecker
    {
        public bool HasTimeConflict(Request a, Request b)
        {
            if (a.DayOfWeek != b.DayOfWeek)
                return false;

            return a.StartHour < b.EndHour && b.StartHour < a.EndHour;
        }
    }
}