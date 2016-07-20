using System;


namespace ProgrammingFundamentals
{
    public class FizzBuzz
    {
        public string Say()
        {
            Promp();

            var usefulMethods = new FizzBuzzUsefulMethods();
           int userInt = usefulMethods.ReadIntForFizzBuzz();

            var stringOutput = userInt.ToString();

            return stringOutput;
        }

        public void Promp()
        {
            string prompt = "Please enter an integer: ";
            Console.WriteLine(prompt);
        }
    }

    public class FizzBuzzUsefulMethods
    {

        public int ReadIntForFizzBuzz()
        {
            var readString = ReadStringForFizzBuzz();
            
            int userInt = int.Parse(readString);
            Console.WriteLine("thanks");
            Console.ReadLine();
            
            return userInt;
        }

        public string ReadStringForFizzBuzz()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}


