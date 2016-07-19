using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentals
{
    class Booleans
    {
        public void SomeBools()
        {
            bool myBoolA = true;
            bool myBoolB = false;

            Console.WriteLine("Are both Booleans true? {0}", 
                myBoolA && myBoolB);
            Console.WriteLine("Is either one of them true? {0}",
                myBoolA || myBoolB);

        }
    }
}
