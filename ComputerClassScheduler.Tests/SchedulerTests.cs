using System.Collections.Generic;

namespace ComputerClassScheduler.Logic
{
    public class Scheduler
    {
        private readonly ConflictChecker _conflictChecker = new ConflictChecker();
        private readonly PriorityResolver _priorityResolver = new PriorityResolver();

        public List<Request> BuildSchedule(List<Request> requests)
        {
            var schedule = new List<Request>();

            foreach (var request in requests)
            {
                bool hasConflict = false;

                for (int i = 0; i < schedule.Count; i++)
                {
                    if (_conflictChecker.HasTimeConflict(schedule[i], request))
                    {
                        var winner = _priorityResolver.Resolve(schedule[i], request);

                        if (winner == request)
                        {
                            schedule[i] = request;
                        }

                        hasConflict = true;
                        break;
                    }
                }

                if (!hasConflict)
                {
                    schedule.Add(request);
                }
            }

            return schedule;
        }
    }
}