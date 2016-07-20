using System;


namespace ProgrammingFundamentals
{
    public class FizzBuzz
    {
        public string Say()
        {
            Promp();
            var readInput = new FizzBuzzUsefulMethods();
            
            string yourIntWas = "Your int was:..";
            var inputInt = readInput.ReadIntForFizzBuzz();
           

            Console.WriteLine(yourIntWas);
            Console.WriteLine(inputInt);
           
            return "fizzOrBuzz";

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
            
            return userInt;
        }

        public string ReadStringForFizzBuzz()
        {
            string userInput = Console.ReadLine();
            Console.WriteLine("thanks");
            return userInput;
        }
    }
}


