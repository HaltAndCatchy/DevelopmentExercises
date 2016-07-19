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

    public class Counter
    {
        public int Request(int value, ref int callCount)
        {
            callCount++;
            if (value >= 10)
            {
                return value;
            }
            return Request(value + 1, ref callCount);
        }

        public string NumberOfTimesCalled()
        {
            int callCount = 0;
            int totalCalls = Request(5, ref callCount);
            string numberOfTimesCalled = totalCalls.ToString();
            return numberOfTimesCalled;
        }
    }
}
