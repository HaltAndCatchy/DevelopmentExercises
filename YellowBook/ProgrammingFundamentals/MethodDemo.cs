using System;

namespace ProgrammingFundamentals
{
    internal class MethodDemo
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


