using System;


namespace ProgrammingFundamentals
{
   public class FizzBuzz
    {
        public string Say()
        {
            return "";
        }
    }

    internal class UsefulMethods
    {

        public int ReadInt()
        {
            var readString = ReadString();
            int userInt = int.Parse(readString);
            return userInt;
        }

        public string ReadString()
        {
            string userInput;
            do
            {
               userInput= Console.ReadLine();
            } while (userInput == "");
            return "";
        }
    }

}
