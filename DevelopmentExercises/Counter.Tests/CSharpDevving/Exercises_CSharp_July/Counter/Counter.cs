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

    public class Counter
    {
        private static int _count;

        
        public static int Request()
        {
            {
                _count++;
            }
           
            var actualAnswer = _count;
            return actualAnswer;
        }

        public static string NumberOfTimesCalled()
        {
            int requestAnswerCounter = _count;
            
            string callCount = requestAnswerCounter.ToString();
           
            return callCount;

        }
    }

   
}
