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

            var inputInt = readInput.ReadStringForFizzBuzz();
            Console.WriteLine(yourIntWas,inputInt); 
           
            return "I'm a string";

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


