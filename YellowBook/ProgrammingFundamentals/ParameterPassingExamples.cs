using System;

namespace ProgrammingFundamentals
{
    internal class ParameterPassingExamples
    {
        public void AddOne(int i)
        {
            i = i + 1;
            Console.WriteLine("i is :" + i);
        }

        public void ReadPerson(out string name, out int age)
        {
            {
                name = ReadString("Enter your name : ");
                age = readInt("Enter your age : ", 0, 100);
            }

        }

        public int readInt(string prompt, int low, int high)
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

