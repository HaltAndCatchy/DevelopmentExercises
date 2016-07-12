using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Counter.Tests
{
    [TestFixture]
    public class CounterTests
    {
        public static void RequestCaller()
        {
            Assert.That(Counter.Request(null), Is.Not.Null);
        }
    }
}
