﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public static void ReturnsString()
        {
            string sayOutPut = FizzBuzz.Say();
            Assert.IsInstanceOf(typeof(String), sayOutPut);
        }

        [Test]
        public static void InputIsInt()
        {
            int sayInput = FizzBuzz.Input();
            Assert.IsInstanceOf(typeof(Int32), sayInput);
        }
    }
}
