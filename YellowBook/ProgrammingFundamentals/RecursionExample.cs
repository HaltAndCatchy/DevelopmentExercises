using System;

namespace ProgrammingFundamentals
{
    class RecursionExample
    {
        public int Recursive(int value, ref int count)
        {
            count++;
            if (value >= 10)
            {
                return value;
            }
            return Recursive(value + 1, ref count);
        }
    }
}
