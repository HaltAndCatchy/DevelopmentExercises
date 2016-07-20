using System;


namespace ProgrammingFundamentals
{
    public class FizzBuzz
    {
        public string Say()
        {
            string prompt = "Please enter an integer: ";
            Console.WriteLine(prompt);

            var usefulMethods = new UsefulMethods();
            usefulMethods.ReadInt();

            return "";
        }
    }

    internal class UsefulMethods
    {

        public int ReadInt()
        {
            var readString = ReadStringForFizzBuzz();
           
            
            int userInt = int.Parse(readString);
            Console.WriteLine("thanks");
            return userInt;
        }

        public string ReadStringForFizzBuzz()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}


