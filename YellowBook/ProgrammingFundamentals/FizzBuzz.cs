using System;


namespace ProgrammingFundamentals
{
    public class FizzBuzz
    {
        public void BaseMethod()
        {
            Prompt();
            var readInput = new FizzBuzzUsefulMethods();
            readInput.CheckIntForFizzBuzz();
            
            Say();

            var sayWhat = new FizzBuzz();
            Console.WriteLine(sayWhat.Say());
        }

        public string Say()
        {
            Console.WriteLine("Say method being executed");

            
            //bool multipleOfThree = MultipleOfThree();
            //if (multipleOfThree)
            //{
            //    return "Placeholder";
            //}
            return "blah";

        }

       

        public void Prompt()
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
        public bool MultipleOfThree()
        {
            var userInt = ReadInt();

            if (userInt % 3 == 0)
            {
                return true;
            }
            return false;
        }
    }
}


