using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp1
{
    public class LogData
    {
        public string EventMessage { get; set; }
        public string EventCategory { get; set; }

        public DateTime EventTime { get; set; }

        public int Priority { get; set; }
    }
}
