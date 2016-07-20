using System;


namespace ProgrammingFundamentals
{
    public class FizzBuzz
    {
        public string Say()
        {
            string prompt = "Please enter an integer: ";
            Console.WriteLine(prompt);

           var usefulMethods = new FizzBuzzUsefulMethods();
           int userInt = usefulMethods.ReadIntForFizzBuzz();

            var stringOutput = userInt.ToString();

            return stringOutput;
        }
    }

    public class FizzBuzzUsefulMethods
    {

        public int ReadIntForFizzBuzz()
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


