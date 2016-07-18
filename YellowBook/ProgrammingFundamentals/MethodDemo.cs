using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentals
{
    class MethodDemo
    {
        private void Silly(int i)
        {
           Console.WriteLine("i is " + i);
           Console.ReadLine();
        }

        public void CalltheOtherOne()
        {
           Silly(101);
           Silly(500);
        }
    }
    
}
