﻿using System;

namespace Counter
{
    public class Exercises
    {
        public static void Main()
        {
        }
    }

    public static class Counter
    {
        public static int Request { get;  set; }

        public static string NumberOfTimesCalled()
        {
            Request++;
            string numberOfTimesCalled = Request.ToString();
            Console.WriteLine(numberOfTimesCalled);
            
            return numberOfTimesCalled;
        }
    }
}
