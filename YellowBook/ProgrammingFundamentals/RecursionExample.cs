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

        public void Caller()
        {
            int count = 0;
            int total = Recursive(5, ref count);

            Console.WriteLine(total);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
