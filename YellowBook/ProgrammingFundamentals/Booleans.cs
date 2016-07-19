using System;

namespace ProgrammingFundamentals
{
    class Booleans
    {
        public void SomeBools()
        {
            bool myBoolA = true;
            bool myBoolB = false;

            Console.WriteLine("Are both Booleans true? {0}", 
                myBoolA && myBoolB);
            Console.WriteLine("Is either one of them true? {0}",
                myBoolA || myBoolB);
        }

        public void ShortCircuiting()
        {
            bool boolA;

            Console.WriteLine("| operator: ");
            boolA = BooleanTrue() | BooleanFalse();

            Console.WriteLine("|| operator: ");
            boolA = BooleanTrue() || BooleanFalse();

            Console.WriteLine("& operator:");
            boolA = BooleanFalse() & BooleanTrue();

            Console.WriteLine("&& operator");
            boolA = BooleanFalse() && BooleanTrue();
        }

        public bool BooleanFalse()
        {
           Console.WriteLine("Executing BooleanFalse() = False");
            return false;
        }

        public bool BooleanTrue()
        {
            Console.WriteLine("  Executing BooleanTrue() = True");
            return true;
        }
    }
}
