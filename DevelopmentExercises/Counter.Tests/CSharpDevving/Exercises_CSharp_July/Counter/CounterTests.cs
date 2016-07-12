using System;
using NUnit.Framework;

namespace Counter
{
   [TestFixture]
    public class CounterTests
    {
       [Test]
       public static void RequestCallsNumberChecker()
       {
           int numberOfTimesCalled = Counter.NumberOfTimesCalled();
         
           Assert.That(numberOfTimesCalled, Is.GreaterThan(0));
       }
       
        [Test]
       public static void NumberOfTimesCalledReturnsString()
        {
            var numberOfTimesCalled = Counter.NumberOfTimesCalled();
            
            Assert.IsInstanceOf(typeof(String), numberOfTimesCalled);
        }
    }
}
