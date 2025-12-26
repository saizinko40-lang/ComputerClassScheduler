using NUnit.Framework;
using ComputerClassScheduler.Logic;

namespace ComputerClassScheduler.Tests
{
    public class PriorityResolverTests
    {
        [Test]
        public void Higher_Priority_Request_Should_Win()
        {
            var low = new Request
            {
                DayOfWeek = 1,
                StartHour = 9,
                EndHour = 11,
                GroupName = "Low",
                GroupPriority = 1
            };

            var high = new Request
            {
                DayOfWeek = 1,
                StartHour = 9,
                EndHour = 11,
                GroupName = "High",
                GroupPriority = 5
            };

            var resolver = new PriorityResolver();

            var winner = resolver.Resolve(low, high);

            Assert.AreEqual("High", winner.GroupName);
        }
    }
}