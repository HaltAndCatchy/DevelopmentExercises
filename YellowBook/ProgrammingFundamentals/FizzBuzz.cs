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
            return 1;
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
