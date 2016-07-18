﻿using System;

namespace ProgrammingFundamentals
{
    class UsefulMethodExercise
    {
        public double ReadValue(string prompt,double low,double high )
        {
            double result = 0;
            do
            {
                Console.WriteLine(prompt + "between" + low + "and" + high);
                string resultString = Console.ReadLine();
                result = double.Parse(resultString);
            } while ((result > low) || (result > high));
            return result;
        }
    }
}
