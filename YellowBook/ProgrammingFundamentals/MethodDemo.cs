using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentals
{
    class MethodDemo
    {
        private void Doit()
        {
            Console.WriteLine("Hello");
            Console.ReadLine();
        }

        public void CallDoIt()
        {
            Doit();
            Doit();
        }
    }
    
}
