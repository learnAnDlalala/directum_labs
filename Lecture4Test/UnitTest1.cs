using NUnit.Framework;
using Task3;

namespace Lecture4Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
            
        }

        [Test]
        public void Test1()
        {
            var testMeeting = new MeetingWithTypes();
            testMeeting.DateType = MeetingTypes.birthDay;
            Assert.AreEqual(MeetingTypes.birthDay, testMeeting.DateType);
        }
    }
}