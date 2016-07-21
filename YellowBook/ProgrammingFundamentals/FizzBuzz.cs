using System;


namespace ProgrammingFundamentals
{
    public class FizzBuzz
    {
        public string Say()
        {
            Promp();
            var readInput = new FizzBuzzUsefulMethods();
            readInput.CheckIntForFizzBuzz();
            //readInput.ReadInt();
            

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
        int _userInt;

        public int ReadInt()
        {
            var readString = ReadStringForFizzBuzz();
            _userInt = int.Parse(readString);
            return _userInt;
        }

        public void CheckIntForFizzBuzz()
        {
            var readString = ReadStringForFizzBuzz();
            try
            {

                _userInt = int.Parse(readString);
                Console.WriteLine("Your int was : {0}", _userInt);
            }
            catch
            {
                Console.WriteLine("Please enter number in correct format");
                CheckIntForFizzBuzz();
            }
            
        }

        public string ReadStringForFizzBuzz()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}


