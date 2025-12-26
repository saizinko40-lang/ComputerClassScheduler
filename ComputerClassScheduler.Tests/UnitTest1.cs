using NUnit.Framework;
using ComputerClassScheduler.Logic;

namespace ComputerClassScheduler.Tests
{
    public class TimeValidationTests
    {
        [Test]
        public void LessonTime_Should_Be_Within_Working_Hours()
        {
            var validator = new TimeValidator();

            bool isValid = validator.IsWithinWorkingHours(9, 11);

            Assert.IsTrue(isValid);
        }
    }
}