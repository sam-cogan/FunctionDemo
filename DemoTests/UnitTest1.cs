using DemoApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;

namespace DemoTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogData()
        {
            var eventMessage = "Log Testing";
            var eventCategory = "Error";
            var eventTime= DateTime.UtcNow;
            var priority = 1;

            var json = " {\"EventMessage\":\"" + eventMessage +"\",\"EventCategory\":\""+ eventCategory +"\",\"EventTime\":\""+ eventTime +"\",\"Priority\":1}";

            var logData = JsonConvert.DeserializeObject<LogData>(json);


            Assert.AreEqual(eventMessage, logData.EventMessage);
            Assert.AreEqual(eventCategory, logData.EventCategory);
            Assert.AreEqual(priority, logData.Priority);


        }
    }
}
