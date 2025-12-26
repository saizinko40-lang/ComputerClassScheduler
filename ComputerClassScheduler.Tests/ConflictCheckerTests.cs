using NUnit.Framework;
using ComputerClassScheduler.Logic;

namespace ComputerClassScheduler.Tests
{
    public class ConflictCheckerTests
    {
        [Test]
        public void Requests_On_Same_Day_With_Overlap_Should_Conflict()
        {
            var r1 = new Request
            {
                DayOfWeek = 1,
                StartHour = 9,
                EndHour = 11,
                GroupName = "A",
                GroupPriority = 1
            };

            var r2 = new Request
            {
                DayOfWeek = 1,
                StartHour = 10,
                EndHour = 12,
                GroupName = "B",
                GroupPriority = 2
            };

            var checker = new ConflictChecker();

            bool conflict = checker.HasTimeConflict(r1, r2);

            Assert.IsTrue(conflict);
        }
    }
}