using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return numberOfTimesCalled;
        }
    }

   
}
