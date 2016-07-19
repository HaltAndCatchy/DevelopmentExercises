using System;

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

    public class MethodLibrary
    {
        public string ReadString(string prompt)
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (result == "");
            return result;
        }
    }
    }

}
