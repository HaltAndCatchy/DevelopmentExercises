using System;

namespace ProgrammingFundamentals
{
    public class MethodLibrary
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
            do{
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (result == "");
            return result;
        }
    }
}