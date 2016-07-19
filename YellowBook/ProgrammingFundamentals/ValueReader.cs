using System;

namespace ProgrammingFundamentals
{
    public class ValueReader
    {
        public double ReadValue(string prompt,double low,double high )
        {
            double result; 
            do
            {
                Console.WriteLine(prompt + "between " + low + " and " + high);
                string resultString = Console.ReadLine();
                result = double.Parse(resultString);
            } while ((result > low) || (result < high));
            return result;
        }
    }
}
