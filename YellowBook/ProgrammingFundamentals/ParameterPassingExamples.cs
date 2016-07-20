using System;

namespace ProgrammingFundamentals
{
    public class ParameterPassingExamples
    {
        private readonly MethodLibrary _methodLibrary = new MethodLibrary();

        public void AddOne(int i)
        {
            i = i + 1;
            Console.WriteLine("i is :" + i);
        }

        //public void ReadPerson(out string name, out int age)
        //{
        //    {
        //        //name = _methodLibrary.ReadString("Enter your name : ");
        //        age = _methodLibrary.ReadInt("Enter your age : ", 0, 100);
        //    }

        //}
    }

}

