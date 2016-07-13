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
           int numberOfTimesCalled = int.Parse(Counter.NumberOfTimesCalled());
         
           Assert.That(numberOfTimesCalled, Is.GreaterThan(0));
       }
       
        [Test]
       public static void NumberOfTimesCalledReturnsString()
        {
            var numberOfTimesCalled = Counter.NumberOfTimesCalled();
            
            Assert.IsInstanceOf(typeof(String), numberOfTimesCalled);
        }

       [Test]
       public static void RequestMethodIsCalled()
       {
           string requestMessage = Counter.Request();
          
           Assert.That(requestMessage, Is.EqualTo("You rang?"));
       }
    }
}
