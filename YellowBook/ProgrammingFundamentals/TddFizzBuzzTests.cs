using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ProgrammingFundamentals
{
   [TestFixture]
    class TddFizzBuzzTests
    {
       [Test]
       public void TranslateOne()
       {
           string result = Translator.Translate(1);
           Assert.That(result, Is.EqualTo("1"));
       }
    }

    
}
