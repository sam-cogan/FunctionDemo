using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using Xunit;

namespace DemoAppTests
{
    public class UnitTest1
    {
        private readonly ILogger logger = NullLoggerFactory.Instance.CreateLogger("Test");
        [Fact]
        public void Test1()
        {

        }
    }
}
