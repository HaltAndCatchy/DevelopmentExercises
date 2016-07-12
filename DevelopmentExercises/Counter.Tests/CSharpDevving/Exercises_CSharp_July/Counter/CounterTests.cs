using NUnit.Framework;

namespace Counter
{
   [TestFixture]
    public class CounterTests
    {
       [Test]
       public static void RequestCallTypeChecker()
       {
           int numberOfTimesCalled = Counter.NumberOfTimesCalled();
         
           Assert.That(numberOfTimesCalled, Is.GreaterThan(0));
       }
    }
}
