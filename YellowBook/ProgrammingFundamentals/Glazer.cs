using System;
using ProgrammingFundamentals;

namespace YellowBook
{
    public class Glazer
    {
        public void WindowWidth()
        {
            double width, height, woodLength, glassArea;

            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;

            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;

            string heightString;

            width = Width(MIN_WIDTH, MAX_WIDTH);

            height = Height(MIN_HEIGHT, MAX_HEIGHT);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width + height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadLine();
        }

        public double Height(double MIN_HEIGHT, double MAX_HEIGHT)
        {
            string heightString;
            double height;
            do
            {
                Console.Write("Give the height of the window between " +
                              MIN_HEIGHT + " and " + MAX_HEIGHT + " :");
                heightString = Console.ReadLine();
                height = double.Parse(heightString);
            } while (height < MIN_HEIGHT || height > MAX_HEIGHT);
            return height;
        }

        public double Width(double MIN_WIDTH, double MAX_WIDTH)
        {
            string widthString;
            double width;
            do
            {
                Console.Write("Give the width of the window between " +
                              MIN_WIDTH + " and " + MAX_WIDTH + " :");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);
            } while (width < MIN_WIDTH || width > MAX_WIDTH);
            return width;
            
        }

    }
}