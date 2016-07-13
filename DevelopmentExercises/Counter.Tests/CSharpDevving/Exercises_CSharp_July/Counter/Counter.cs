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

        
        public static string Request()
        {
            {
                _count++;
            }
           
            var actualAnswer = "You rang?";
            return actualAnswer;
        }

        public static string NumberOfTimesCalled()
        {
            var requestAnswer = Request();
            int requestAnswerCounter = _count;
            
            
            //if (Request().Contains(" ")) 
               
            string callCount = requestAnswerCounter.ToString();
           
            return callCount;

            return null;
        }
    }

   
}
