using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentals
{
    class ScratchPad
    {
    }

    public class CallMe
    {
        public int Request()
        {
            return 1;
        }

        public string NumberOfTimesCalled()
        {
            var callMe = new CallMe();
            int call = callMe.Request();
            string callMade = call.ToString();
            Console.WriteLine(callMade);
            return callMade;
        }
    }
}
