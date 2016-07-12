using NUnit.Framework;

namespace Counter
{
   [TestFixture]
    public class CounterTests
    {
       [Test]
       public static void RequestChecker()
       {
           Assert.That(Counter.Request, Is.Not.Empty);
       }
    }
}
