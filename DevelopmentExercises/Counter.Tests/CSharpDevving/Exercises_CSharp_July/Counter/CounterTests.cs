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

       //[Test]
       //public static void RequestMethodReturnsInt()
       //{
       //    int actualAnswer = Counter.Request();
       //    Assert.IsInstanceOf(typeof(int), actualAnswer);
       //}

       //[Test]
       //public static void NumberOfTimesCalledCallsRequestMethod()
       //{
       //    int callRequest =  int.Parse(Counter.NumberOfTimesCalled());
       //    var actualAnswer = Counter.Request();
          
       //    Assert.That(callRequest, Is.EqualTo(actualAnswer));
       //}
    }
}
