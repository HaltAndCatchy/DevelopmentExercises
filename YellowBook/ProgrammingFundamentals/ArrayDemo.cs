using System;

namespace ProgrammingFundamentals
{
    class ArrayDemo
    {
        public void DemoSomeArrays()
        {
            var methodLibrary = new MethodLibrary();

            int[] scores = new int[11];
            for (int i = 0; i < 11; i = i + 1)
            {
                scores[i] = methodLibrary.ReadInt("Score : ", 0, 100);
            }
        }
    }
}
