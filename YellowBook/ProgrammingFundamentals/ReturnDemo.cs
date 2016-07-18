using System;

namespace ProgrammingFundamentals
{
    class ReturnDemo
    {
        private int SillyReturnPlus(int i)
        {
            i = i + 1;
            Console.WriteLine("i is : " + i);
            return i;
        }

        public void returningDemo()
        {
            int res;
            res = SillyReturnPlus(5);
            Console.WriteLine("res is : " + res);
            Console.ReadLine();
        }
    }
}
