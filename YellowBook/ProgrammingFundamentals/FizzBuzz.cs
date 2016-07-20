using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentals
{
    class FizzBuzz
    {
        public string Say(ref int fizzBuzzNumber)
        {
            string response = "";
            return response;
        }
    }

    internal class UsefulMethods
    {

        public int ReadInt(string prompt, int low, int high)
        {
            int result;
            do
            {
                string intString = ReadString(prompt);
                result = int.Parse(intString);
            } while ((result < low) || (result > high));
            return result;
        }

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
